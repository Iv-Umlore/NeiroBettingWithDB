using INetwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectHelper;

namespace FootBall.Network
{
    public class FootBallNetwork : INetworkInterface
    {
        private string pathToWeights;
        private string pathToWeightHistory;

        public FootBallNetwork()
        {
            pathToWeights = "../Weights/Current/FootBall/";     // Вынести в конфиг, или в константы хелпера
            pathToWeightHistory = "../Weights/History/FootBall/";     // Вынести в конфиг, или в константы хелпера
        }

        /*public List<Prediction> GetPrediction(List<PastMatches> teamAMatches, List<PastMatches> teamBMatches, Tournament tournament, string[] parameters)
        {
            return new List<Prediction>();
        }*/

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
