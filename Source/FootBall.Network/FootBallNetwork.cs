using INetwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectHelper;

namespace Network.Football
{
    public class FootballNetwork : INetworkInterface
    {
        private string pathToWeights;
        private string pathToWeightHistory;
        private List<Network> netNetwork;

        public FootballNetwork()
        {
            pathToWeights = "../Weights/Current/FootBall/";     // Вынести в конфиг, или в константы хелпера
            pathToWeightHistory = "../Weights/History/FootBall/";     // Вынести в конфиг, или в константы хелпера
            pathToWeights = "../Weights/Current/FootBall/";     // Вынести в конфиг, или в константы хелпера
            pathToWeightHistory = "../Weights/History/FootBall/";     // Вынести в конфиг, или в константы хелпера
            netNetwork = new List<Network>();
            netNetwork.Add(new Network("TotalGoals", 3, 151, 1, new List<int>() { 40, 20, 10, 5 }));
            netNetwork.Add(new Network("Save A", 3, 151, 1, new List<int>() { 40, 20, 10, 5 }));
            netNetwork.Add(new Network("Save B", 3, 151, 1, new List<int>() { 40, 20, 10, 5 }));
            netNetwork.Add(new Network("Violations A", 3, 151, 1, new List<int>() { 40, 20, 10, 5 }));
            netNetwork.Add(new Network("Violations B", 3, 151, 1, new List<int>() { 40, 20, 10, 5 }));
            netNetwork.Add(new Network("Shot A", 3, 151, 1, new List<int>() { 40, 20, 10, 5 }));
            netNetwork.Add(new Network("Shot B", 3, 151, 1, new List<int>() { 40, 20, 10, 5 }));
            // + tournament
            netNetwork.Add(new Network("Vanga", 2, 10, 10, new List<int>() { 10, 10, 10 }));
        }

        public List<Prediction> GetPrediction(List<LastMatch> teamAMatches, List<LastMatch> teamBMatches, TournamentShort tournament, string[] parameters)
        {
            // 15 параметров для 1 матча + турнир
            return new List<Prediction>();
        }

        public double TestNetwork()
        {
            return 0.0;
        }

        public double Learning()
        {
            return 0.0;
        }

        public void SaveCurrentWeights() { }

        public void ReloadWeights() { }

        public bool ChangeDiscipline(Discipline type)
        {
            // Заглушка
            return true;
        }
    }
}
