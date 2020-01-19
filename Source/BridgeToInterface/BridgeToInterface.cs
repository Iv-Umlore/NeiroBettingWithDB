using InteractionInterface;
using InterpritatorController;
using InterpritatorInterface;
using NetworkInterface;
using ProjectHelper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BridgeToInterface
{
    public class BridgeToInterfaceController
    {
        private IInteractionControllerInterface _interactionController;
        private INetworkInterface _network;
        private IInterpritatorInterface _interpritator;
        private List<TeamInfo> teamList;
        private List<TournamentShort> tournamentList;
        private List<LastMatch> lastMatchesA;
        private List<LastMatch> lastMatchesB;
        public int MatchesCount;
        public string learningResult;

        Dictionary<LastMatch, List<LastMatch>> matchesForLearning;

        public BridgeToInterfaceController()
        {
            _interactionController = new InteractionController.InteractionController(Discipline.Football);
            _network = new NetworkController.NetworkController(Discipline.Football);
            _interpritator = new InterpritatorController.InterpritatorController(Discipline.Football);
            matchesForLearning = new Dictionary<LastMatch, List<LastMatch>>();
            teamList = _interactionController.GetTeamList();
            MatchesCount = 1000;
            learningResult = string.Empty;

            lastMatchesA = new List<LastMatch>();
            lastMatchesB = new List<LastMatch>();

    }

        public bool ChangeDiscipline(Discipline discipline)
        {
            _interactionController.ChangeDiscipline(discipline);
            _network.ChangeDiscipline(discipline);
            _interpritator.ChangeDiscipline(discipline);
            return true;
        }

        public List<MatchWaitResult> GetWaitResultMatches()
        {
            var result = _interactionController.GetWaitResultMatches();
            return result;
        }
        
        public bool SaveLastMatchResult(bool ReadyForLearning, DateTime dateTime, string[] parameters)
        {
            _interactionController.SaveMatchResult(parameters, dateTime, ReadyForLearning);
            return true;
        }

        public List<string> GetTeamList(string withoutTeam_name = "")
        {
            teamList = _interactionController.GetTeamList();
            if (withoutTeam_name == "")
                return teamList.Select(it => it.Team_name).ToList();
            else return teamList.Where(it => it.Team_name != withoutTeam_name).Select(it => it.Team_name).ToList();
        }

        public List<string> GetTournamentList()
        {
            tournamentList = _interactionController.GetTournamentList();
            return tournamentList.Select(it => it.Tournament_name).ToList();
        }

        public bool AddNewTeam(string abbreviature, string TeamName, int tier_team, int teamPoint)
        {
            _interactionController.AddNewTeam(abbreviature, TeamName, tier_team);
            teamList = _interactionController.GetTeamList();
            return true;
        }

        public bool AddNewTournament(string TournamentName, int size)
        {
            _interactionController.AddNewTournament(TournamentName, size);
            return true;
        }

        public List<LastMatch> GetLastFiveMatch(bool isItA, string TeamName)
        {
            if (isItA)
                return lastMatchesA = _interactionController.GetlastFiveTeamMatch(TeamName);
            else
                return lastMatchesB = _interactionController.GetlastFiveTeamMatch(TeamName);
        }
        
        public string GetPrediction(string[] parameters, DateTime date)
        {
            var tournament = tournamentList.First(it => it.Tournament_name == parameters[0]);
            var tierA = 0.0;
            var tierB = 0.0;
            List<double> tmpValue = new List<double>();
            foreach (var lastMatches in lastMatchesA)
                tmpValue.AddRange(lastMatches.ToListDouble());
            
            foreach (var lastMatches in lastMatchesB)
                tmpValue.AddRange(lastMatches.ToListDouble());
            
            // Получение ранга команд из прошлых матчей (интересный костыль)
            tierA = tmpValue[8];
            tierB = tmpValue[83];

            var statisticPredicts = _network.GetHistoryPrediction(tmpValue);

            var finalInputParameters = new List<double>();
            // Учесть, что количество сейвов - дробное число и его не надо преобразовать
            for (int i = 0; i < statisticPredicts.Count; i++)
                if (i != 1 && i != 2)
                    finalInputParameters.AddRange(_interpritator.GetPrediction(statisticPredicts[i]));
                else {
                    finalInputParameters.Add(statisticPredicts[i]);
                    finalInputParameters.Add(statisticPredicts[i]);
                }

            for (int i = 0; i < statisticPredicts.Count; i++)
                if (i != 1 && i != 2)
                    finalInputParameters[i] = _interpritator.GetPerfectValue((int)statisticPredicts[i]);

            var prediction = "ТБ:  " + ((finalInputParameters[0] + finalInputParameters[1]) / 2).ToString("f1") +
                " Ударов А: " + ((finalInputParameters[10] + finalInputParameters[11]) / 2).ToString("f2") +
                " Ударов В: " + ((finalInputParameters[12] + finalInputParameters[13]) / 2).ToString("f2") +
                " %Save A: " + ((finalInputParameters[2] + finalInputParameters[3]) / 2).ToString("f2") +
                " %Save B: " + ((finalInputParameters[4] + finalInputParameters[5]) / 2).ToString("f2") + ";";

            // Вывести приколы интерпритаторов.

            // Дополнительные параметры для итоговой нейронной сети
            finalInputParameters.Add(tierA);
            finalInputParameters.Add(tierB);
            // Важность для домашней команды и команды гостей
            finalInputParameters.Add(int.Parse(parameters[3]));
            finalInputParameters.Add(int.Parse(parameters[4]));
            // Замены у домашней команды и команды гостей
            finalInputParameters.Add(int.Parse(parameters[5]));
            finalInputParameters.Add(int.Parse(parameters[6]));
            finalInputParameters.Add(tournament.Tournament_size);

            /// Вычисление итогового результата.
            /// Результат - массив из 10 чисел. Число, первым выходящее за Епсилон больше 0.1 от Единицы,
            /// считается результатом с умеренным риском. Для преобразования результата в более понятный вид
            /// необходимо воспользоваться интерпритатором
            var finalPredict = _network.GetFinalPrediction(finalInputParameters);
            prediction += _interpritator.GetPrediction(finalPredict);
            _interactionController.AddNewWaitResultMatch(parameters, tournament, date, prediction);

            return prediction;
        }

        public string TestNetwork()
        {
            return _network.TestNetwork(matchesForLearning);
        }

        public string LearningNetwork()
        {
            learningResult = _network.Learning(matchesForLearning);
            return learningResult;
        }

        public bool SaveCurrentWeights()
        {
            _network.SaveCurrentWeights();
            return true;
        }

        public bool ReloadWeights()
        {
            _network.ReloadWeights();
            return true;
        }

        public int DownloadInfoForTest()
        {
            matchesForLearning = _interactionController.GetMatchForLearning();
            return matchesForLearning.Count;
        }

        public void DeleteWaitResultMatch(int teamA, int teamB, DateTime date)
        {
            _interactionController.DeleteWaitResultMatch(teamA, teamB, date);
        }
    }
}
