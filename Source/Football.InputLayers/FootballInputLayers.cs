using Abstract.InputLayer;
using ProjectHelper;
using System.Collections.Generic;
using System.Linq;

namespace Football.InputLayers
{
    public class FootballInputLayers : InputLayerAbstract
    {
        public FootballInputLayers(int inputParametersCount, int outputParametersCount, NetworkType nType) : base(inputParametersCount, outputParametersCount, nType) { }

        public override List<double> GetValueForNetwork(List<double> values)
        {

            var lastMatch = ConvertToLastMatch(values);

            switch (_networkT)
            {
                case NetworkType.Football_Total: return GetStatistic_TotalGoals(lastMatch);
                case NetworkType.Football_SaveA: return GetStatisticSave_A(lastMatch);
                case NetworkType.Football_SaveB: return GetStatisticSave_B(lastMatch);
                case NetworkType.Football_ViolationsA: return GetStatisticViolations_A(lastMatch.Take(5).ToList());
                case NetworkType.Football_ViolationsB: return GetStatisticViolations_B(lastMatch.Skip(5).ToList());
                case NetworkType.Football_ShotA: return GetStatisticShot_A(lastMatch.Take(5).ToList());
                case NetworkType.Football_ShotB: return GetStatisticShot_B(lastMatch.Skip(5).ToList());
                case NetworkType.Football_Vanga: return GetVangaInput(values);
                default: return base.GetValueForNetwork(values);
            }        
            
        }

        protected override double GetDoubleValue(List<double> OneMatch)
        {
            return 0.0;
        }

        /// <summary>
        /// Оценочное число количества мячей в предыдущих матчах
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        private List<double> GetStatistic_TotalGoals(List<LastMatch> values)
        {
            var result = new List<double>();
            int i = 0;
            foreach (var lastMatch in values)
            {
                // Вычисление коэффициентов влияния Ранга команд, важности матча для команд, и замен, а так же размерности турнира
                var tierCoeff = HelpFunctions.GetMatchCoeffByTier(lastMatch.tier_A, lastMatch.tier_B);
                var importantCoeff = HelpFunctions.GetCoeffByImportant(lastMatch.Important_A - lastMatch.Important_B);
                var replasementCoeff = HelpFunctions.GetCoeffByReplacement(lastMatch.replacements_A, lastMatch.replacements_B);
                var tournamentCoeff = HelpFunctions.GetCoeffByTournament(lastMatch.tier_tournament, lastMatch.tier_A, lastMatch.tier_B);
                /// Подсчёт итогового числа и его корректировка (хорошо, как и ожидалось, команда А отыграла не оч)
                /// Если оцениваемая команда А сильнее, то действует принцип - можно было лучше - результат занижается
                /// Если команда А хуже, то счёт 2 3 намного более весомый. тк они боролись
                var tmp = (lastMatch.Score_A + lastMatch.Score_B) * tierCoeff * importantCoeff * replasementCoeff * tournamentCoeff;
                result.Add(tmp);
            }

            return result;
        }

        /// <summary>
        /// Оценка уровня игры вратаря команды A на основе предыдущих 5 матчей, а так же качества нападения команды B
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        private List<double> GetStatisticSave_A(List<LastMatch> values)
        {
            // Уровень вратаря
            List<double> saveArrayA = new List<double>();
            // Уровень нападения
            List<double> goodShootArrayB = new List<double>();

            double tmp = 0.0;

            foreach (var match in values.Take(5).ToList())
            {
                // Вычисление коэффициентов влияния Ранга команд, важности матча для команд, и замен
                var tierCoeff = HelpFunctions.GetMatchCoeffByTier(match.tier_A, match.tier_B);
                var importantCoeff = HelpFunctions.GetCoeffByImportant(match.Important_A - match.Important_B);
                var replasementCoeff = HelpFunctions.GetCoeffByReplacement(match.replacements_A, match.replacements_B);
                var tournamentCoeff = HelpFunctions.GetCoeffByTournament(match.tier_tournament, match.tier_A, match.tier_B);
                /// Подсчёт итогового числа и его корректировка
                /// Считаем отношение ударов в створ к числу сейвов. Число больше 1.
                /// Если Уровень команды лучше, то tierCoeff больше 1. Каждая ошибка команды намного важнее
                /// Если уровень команды ниже, то tierCoeff меньше 1. Ошибки можно прощать
                /// Если матч важен для команды, то важность больше 1 и каждая ошибка более существенна
                /// Если не важен, то важность меньше 1, но каждая ошибка не так существенна
                /// Ещё не реализована зависимость от замен
                tmp = ((match.save_A + 1) / (match.shot_on_target_B + 1)) * tierCoeff * importantCoeff * replasementCoeff * tournamentCoeff;
                saveArrayA.Add(tmp);
            }
            // В итоговый массив поступает отсортированный по убыванию массив.
            saveArrayA.OrderByDescending(it=>it);

            foreach (var match in values.Skip(5).ToList())
            {
                // Вычисление коэффициентов влияния Ранга команд, важности матча для команд, и замен
                var tierCoeff = HelpFunctions.GetMatchCoeffByTier(match.tier_A, match.tier_B);
                var importantCoeff = HelpFunctions.GetCoeffByImportant(match.Important_A - match.Important_B);
                var replasementCoeff = HelpFunctions.GetCoeffByReplacement(match.replacements_A, match.replacements_B);
                var tournamentCoeff = HelpFunctions.GetCoeffByTournament(match.tier_tournament, match.tier_A, match.tier_B);
                /// Подсчёт итогового числа и его корректировка
                /// Считаем отношение ударов в створ к числу сейвов. Число больше 1.
                /// Если Уровень команды лучше, то tierCoeff больше 1. Каждая ошибка команды намного важнее
                /// Если уровень команды ниже, то tierCoeff меньше 1. Ошибки можно прощать
                /// Если матч важен для команды, то важность больше 1 и каждая ошибка более существенна
                /// Если не важен, то важность меньше 1, но каждая ошибка не так существенна
                /// Ещё не реализована зависимость от замен
                tmp = ((match.shot_on_target_A + 1) / (match.save_B + 1)) * tierCoeff * importantCoeff * replasementCoeff * tournamentCoeff;
                goodShootArrayB.Add(tmp);
            }
            // В итоговый массив поступает отсортированный по убыванию массив.
            goodShootArrayB.OrderByDescending(it => it);

            var result = new List<double>();
            result.AddRange(saveArrayA);
            result.AddRange(goodShootArrayB);

            return result;
        }

        /// <summary>
        /// Оценка уровня игры вратаря команды B на основе предыдущих 5 матчей, а так же качества нападения команды A
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        private List<double> GetStatisticSave_B(List<LastMatch> values)
        {
            // Уровень вратаря
            List<double> saveArrayB = new List<double>();
            // Уровень нападения
            List<double> goodShootArrayA = new List<double>();

            double tmp = 0.0;

            foreach (var match in values.Skip(5).ToList())
            {
                // Вычисление коэффициентов влияния Ранга команд, важности матча для команд, и замен
                var tierCoeff = HelpFunctions.GetMatchCoeffByTier(match.tier_A, match.tier_B);
                var importantCoeff = HelpFunctions.GetCoeffByImportant(match.Important_A - match.Important_B);
                var replasementCoeff = HelpFunctions.GetCoeffByReplacement(match.replacements_A, match.replacements_B);
                var tournamentCoeff = HelpFunctions.GetCoeffByTournament(match.tier_tournament, match.tier_A, match.tier_B);
                // Подсчёт итогового числа и его корректировка
                tmp = ((match.save_A + 1) / (match.shot_on_target_B + 1)) * tierCoeff * importantCoeff * replasementCoeff * tournamentCoeff;
                saveArrayB.Add(tmp);
            }
            // В итоговый массив поступает отсортированный по убыванию массив.
            saveArrayB.OrderByDescending(it => it);

            foreach (var match in values.Take(5).ToList())
            {
                // Вычисление коэффициентов влияния Ранга команд, важности матча для команд, и замен
                var tierCoeff = HelpFunctions.GetMatchCoeffByTier(match.tier_A, match.tier_B);
                var importantCoeff = HelpFunctions.GetCoeffByImportant(match.Important_A - match.Important_B);
                var replasementCoeff = HelpFunctions.GetCoeffByReplacement(match.replacements_A, match.replacements_B);
                var tournamentCoeff = HelpFunctions.GetCoeffByTournament(match.tier_tournament, match.tier_A, match.tier_B);
                // Подсчёт итогового числа и его корректировка
                tmp = ((match.shot_on_target_A + 1) / (match.save_B + 1)) * tierCoeff * importantCoeff * replasementCoeff * tournamentCoeff;
                goodShootArrayA.Add(tmp);
            }
            // В итоговый массив поступает отсортированный по убыванию массив.
            goodShootArrayA.OrderByDescending(it => it);

            var result = new List<double>();
            result.AddRange(saveArrayB);
            result.AddRange(goodShootArrayA);

            return result;
        }

        /// <summary>
        /// Вычислить примерный уровень агрессии команды А (усредненное откорректированное число нарушений)
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        private List<double> GetStatisticViolations_A(List<LastMatch> values)
        {
            var result = new List<double>();

            foreach (var match in values){
                // Вычисление коэффициентов влияния Ранга команд, важности матча для команд 
                // Считаем, что замены и уровень турнира не влияют на агрессию игры команды
                var tierCoeff = HelpFunctions.GetMatchCoeffByTier(match.tier_A, match.tier_B);
                var importantCoeff = HelpFunctions.GetCoeffByImportant(match.Important_A - match.Important_B);
                // Добавление откорректированноего результата
                result.Add(match.Violations_A * importantCoeff * tierCoeff);
            }
            // В итоговый массив поступает отсортированный по убыванию массив.
            result.OrderByDescending(it => it);

            return result;
        }

        private List<double> GetStatisticViolations_B(List<LastMatch> values)
        {
            var result = new List<double>();

            foreach (var match in values)
            {
                // Вычисление коэффициентов влияния Ранга команд, важности матча для команд 
                // Считаем, что замены не влияют на агрессию игры команды
                var tierCoeff = HelpFunctions.GetMatchCoeffByTier(match.tier_A, match.tier_B);
                var importantCoeff = HelpFunctions.GetCoeffByImportant(match.Important_A - match.Important_B);
                // Добавление откорректированноего результата
                result.Add(match.Violations_A * importantCoeff * tierCoeff);
            }
            // В итоговый массив поступает отсортированный по убыванию массив.
            result.OrderByDescending(it => it);

            return result;
        }

        /// <summary>
        /// Оценка количества ударов в створ за последние 5 матчей
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        private List<double> GetStatisticShot_A(List<LastMatch> values)
        {
            var result = new List<double>();
            var tmp = 0.0;

            foreach (var match in values)
            {
                // Вычисление коэффициентов влияния Ранга команд, важности матча для команд 
                var tierCoeff = HelpFunctions.GetMatchCoeffByTier(match.tier_A, match.tier_B);
                var importantCoeff = HelpFunctions.GetCoeffByImportant(match.Important_A - match.Important_B);
                var replasementCoeff = HelpFunctions.GetCoeffByReplacement(match.replacements_A, match.replacements_B);
                var tournamentCoeff = HelpFunctions.GetCoeffByTournament(match.tier_tournament, match.tier_A, match.tier_B);
                /// Вычисляем соотношение ударов в створ команд. И корректируем их
                /// Если оцениваемая команда сильнее, то отношение должно быть больше 1.
                /// Если это не так - это плохой результат. Он должен ещё сильнее ухудшаться
                /// Если слабее наобортот. Точно так же с мотивацией играть.
                tmp = ((match.shot_on_target_A + 1) / (match.shot_on_target_B + 1)) * importantCoeff * tierCoeff * replasementCoeff * tournamentCoeff;
                result.Add(tmp);
            }

            return result;
        }

        private List<double> GetStatisticShot_B(List<LastMatch> values)
        {
            var result = new List<double>();
            var tmp = 0.0;

            foreach (var match in values)
            {
                // Вычисление коэффициентов влияния Ранга команд, важности матча для команд 
                var tierCoeff = HelpFunctions.GetMatchCoeffByTier(match.tier_A, match.tier_B);
                var importantCoeff = HelpFunctions.GetCoeffByImportant(match.Important_A - match.Important_B);
                var replasementCoeff = HelpFunctions.GetCoeffByReplacement(match.replacements_A, match.replacements_B);
                var tournamentCoeff = HelpFunctions.GetCoeffByTournament(match.tier_tournament, match.tier_A, match.tier_B);
                /// Вычисляем соотношение ударов в створ команд. И корректируем их
                /// Если оцениваемая команда сильнее, то отношение должно быть больше 1.
                /// Если это не так - это плохой результат. Он должен ещё сильнее ухудшаться
                /// Если слабее наобортот. Точно так же с мотивацией играть.
                tmp = ((match.shot_on_target_A + 1) / (match.shot_on_target_B + 1)) * importantCoeff * tierCoeff * replasementCoeff * tournamentCoeff;
                result.Add(tmp);
            }

            return result;
        }
        
        private List<double> GetVangaInput(List<double> values)
        {
            /// На вход 14 чисел что-то обозначающих.
            /// А так же 7 чисел которые задают дополнительные параметры
            /// Уровень команд(2), Важность матча(2), Количество замен(2)
            /// Уровень турнира

            // Вычисление коэффициентов влияния Ранга команд, важности матча для команд, и замен, а так же размерности турнира
            var tierCoeff = HelpFunctions.GetMatchCoeffByTier((int)values[14], (int)values[15]);
            var importantCoeff = HelpFunctions.GetCoeffByImportant((int)(values[16] - values[17]));
            var replasementCoeff = HelpFunctions.GetCoeffByReplacement((int)values[18], (int)values[19]);
            var tournamentCoeff = HelpFunctions.GetCoeffByTournament((int)values[20], (int)values[14], (int)values[15]);

            var result = new List<double>();

            for (int i = 0; i < 14; i++)
                result.Add(values[i] * tierCoeff * importantCoeff * replasementCoeff * tournamentCoeff);

            return result;
        }

        private List<LastMatch> ConvertToLastMatch(List<double> values)
        {
            var res = new List<LastMatch>();
            int i = 0;

            if (values.Count % 15 == 0)
            {
                while (i < 150)
                {
                    var tmp = new LastMatch()
                    {
                        Score_A = (short) values[i],                   Score_B = (short) values[i + 1],
                        Violations_A = (short) values[i + 2],          Violations_B = (short) values[i + 3],
                        shot_on_target_A = (short) values[i + 4],      shot_on_target_B = (short) values[i + 5],
                        save_A = (short) values[i + 6],                save_B = (short) values[i + 7],
                        tier_A = (int) values[i + 8],                  tier_B = (int) values[i + 9],
                        Important_A = (short) values[i + 10],          Important_B = (short) values[i + 11],
                        replacements_A = (short) values[i + 12],       replacements_B = (short) values[i + 13],
                        tier_tournament = (short) values[i + 14]
                    };
                    i += 15; // Очень грязно, но как есть)
                    res.Add(tmp);
                }
            }

            return res;
        }
    }
}
