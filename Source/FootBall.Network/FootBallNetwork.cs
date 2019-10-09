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

        public FootballNetwork()
        {
            pathToWeights = "../Weights/Current/FootBall/";     // Вынести в конфиг, или в константы хелпера
            pathToWeightHistory = "../Weights/History/FootBall/";     // Вынести в конфиг, или в константы хелпера
        }

        public List<Prediction> GetPrediction(List<LastMatch> teamAMatches, List<LastMatch> teamBMatches, TournamentShort tournament, string[] parameters)
        {
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
