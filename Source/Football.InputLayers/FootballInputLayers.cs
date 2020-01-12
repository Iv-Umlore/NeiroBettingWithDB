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
                case NetworkType.Football_Total: return GetStatisticTotalGoals(lastMatch);
                case NetworkType.Football_SaveA: return GetStatisticSaveA(lastMatch);
                case NetworkType.Football_SaveB: return GetStatisticSaveB(lastMatch);
                case NetworkType.Football_ViolationsA: return GetStatisticViolationsA(lastMatch.Take(5).ToList());
                case NetworkType.Football_ViolationsB: return GetStatisticViolationsB(lastMatch.Skip(5).ToList());
                case NetworkType.Football_ShotA: return GetStatisticShotA(lastMatch.Take(5).ToList());
                case NetworkType.Football_ShotB: return GetStatisticShotB(lastMatch.Skip(5).ToList());
                case NetworkType.Football_Vanga: return GetVangaInput(values);
                default: return base.GetValueForNetwork(values);
            }        
            
        }

        protected override double GetDoubleValue(List<double> OneMatch)
        {
            return 0.0;
        }

        private List<double> GetStatisticTotalGoals(List<LastMatch> values)
        {
            var result = new List<double>();
            int i = 0;
            foreach (var lastMatch in values)
            {
                var tierCoeff = HelpFunctions.GetMatchCoeffByTier(lastMatch.tier_A, lastMatch.tier_B);
                var importantCoeff = HelpFunctions.GetCoeffByImportant(lastMatch.Important_A - lastMatch.Important_B);
                var replasementCoeff = HelpFunctions.GetCoeffByReplacement(lastMatch.replacements_A, lastMatch.replacements_B);
                var tmp = (lastMatch.Score_A + lastMatch.Score_B) * tierCoeff * importantCoeff * replasementCoeff;
                result.Add(tmp);
            }

            return result;
        }

        private List<double> GetStatisticSaveA(List<LastMatch> values)
        {
            List<double> saveArrayA = new List<double>();
            List<double> goodShootArrayB = new List<double>();

            double tmp = 0.0;

            foreach (var match in values.Take(5).ToList())
            {
                var tierCoeff = HelpFunctions.GetMatchCoeffByTier(match.tier_A, match.tier_B);
                var importantCoeff = HelpFunctions.GetCoeffByImportant(match.Important_A - match.Important_B);
                var replasementCoeff = HelpFunctions.GetCoeffByReplacement(match.replacements_A, match.replacements_B);
                tmp = (match.save_A / match.shot_on_target_B) * tierCoeff / importantCoeff * replasementCoeff;
                saveArrayA.Add(tmp);
            }

            saveArrayA.OrderByDescending(it=>it);

            foreach (var match in values.Skip(5).ToList())
            {
                var tierCoeff = HelpFunctions.GetMatchCoeffByTier(match.tier_A, match.tier_B);
                var importantCoeff = HelpFunctions.GetCoeffByImportant(match.Important_A - match.Important_B);
                var replasementCoeff = HelpFunctions.GetCoeffByReplacement(match.replacements_A, match.replacements_B);
                tmp = (match.shot_on_target_A / match.save_B) * tierCoeff / importantCoeff * replasementCoeff;
                goodShootArrayB.Add(tmp);
            }

            goodShootArrayB.OrderByDescending(it => it);

            var result = new List<double>();
            result.AddRange(saveArrayA);
            result.AddRange(goodShootArrayB);

            return result;
        }

        private List<double> GetStatisticSaveB(List<LastMatch> values)
        {
            List<double> saveArrayB = new List<double>();
            List<double> goodShootArrayA = new List<double>();

            double tmp = 0.0;

            foreach (var match in values.Skip(5).ToList())
            {
                var tierCoeff = HelpFunctions.GetMatchCoeffByTier(match.tier_A, match.tier_B);
                var importantCoeff = HelpFunctions.GetCoeffByImportant(match.Important_A - match.Important_B);
                var replasementCoeff = HelpFunctions.GetCoeffByReplacement(match.replacements_A, match.replacements_B);
                tmp = (match.save_A / match.shot_on_target_B) * tierCoeff / importantCoeff * replasementCoeff;
                saveArrayB.Add(tmp);
            }

            saveArrayB.OrderByDescending(it => it);

            foreach (var match in values.Take(5).ToList())
            {
                var tierCoeff = HelpFunctions.GetMatchCoeffByTier(match.tier_A, match.tier_B);
                var importantCoeff = HelpFunctions.GetCoeffByImportant(match.Important_A - match.Important_B);
                var replasementCoeff = HelpFunctions.GetCoeffByReplacement(match.replacements_A, match.replacements_B);
                tmp = (match.shot_on_target_A / match.save_B) * tierCoeff / importantCoeff * replasementCoeff;
                goodShootArrayA.Add(tmp);
            }

            goodShootArrayA.OrderByDescending(it => it);

            var result = new List<double>();
            result.AddRange(saveArrayB);
            result.AddRange(goodShootArrayA);

            return result;
        }

        private List<double> GetStatisticViolationsA(List<LastMatch> values)
        {
            var result = new List<double>();

            foreach (var match in values){
                var tierCoeff = HelpFunctions.GetMatchCoeffByTier(match.tier_A, match.tier_B);
                var importantCoeff = HelpFunctions.GetCoeffByImportant(match.Important_A - match.Important_B);
                result.Add(match.Violations_A * importantCoeff / tierCoeff);
            }

            result.OrderByDescending(it => it);

            return result;
        }

        private List<double> GetStatisticViolationsB(List<LastMatch> values)
        {
            var result = new List<double>();

            foreach (var match in values)
            {
                var tierCoeff = HelpFunctions.GetMatchCoeffByTier(match.tier_A, match.tier_B);
                var importantCoeff = HelpFunctions.GetCoeffByImportant(match.Important_A - match.Important_B);
                result.Add(match.Violations_A * importantCoeff / tierCoeff);
            }

            result.OrderByDescending(it => it);

            return result;
        }

        private List<double> GetStatisticShotA(List<LastMatch> values)
        {
            var result = new List<double>();
            var tmp = 0.0;

            foreach (var match in values)
            {
                var tierCoeff = HelpFunctions.GetMatchCoeffByTier(match.tier_A, match.tier_B);
                var importantCoeff = HelpFunctions.GetCoeffByImportant(match.Important_A - match.Important_B);
                tmp = (match.shot_on_target_A / match.shot_on_target_B) / importantCoeff / tierCoeff;
                result.Add(tmp);
            }

            return result;
        }

        private List<double> GetStatisticShotB(List<LastMatch> values)
        {
            var result = new List<double>();
            var tmp = 0.0;

            foreach (var match in values)
            {
                var tierCoeff = HelpFunctions.GetMatchCoeffByTier(match.tier_A, match.tier_B);
                var importantCoeff = HelpFunctions.GetCoeffByImportant(match.Important_A - match.Important_B);
                tmp = (match.shot_on_target_A / match.shot_on_target_B) / importantCoeff / tierCoeff;
                result.Add(tmp);
            }

            return result;
        }
        
        private List<double> GetVangaInput(List<double> values)
        {
            // 4 последних числа - важность и замены команд
            // Изменить эту хуйню в будущем
            return values;
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
                        replacements_A = (short) values[i + 12], replacements_B = (short) values[i + 13],
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
