using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectHelper;
using NetworkInterface;
using Football.Network;

namespace NetworkController
{
    public class NetworkController : INetworkInterface
    {
        private INetworkInterface _network;

        public NetworkController(Discipline type)
        {
            switch (type)
            {
                case Discipline.Football:
                    _network = new FootballNetwork();
                    break;
                default: break;
            }
        }
        
        public double TestNetwork(Dictionary<LastMatch, List<LastMatch>> matches)
        {
            return _network.TestNetwork(matches);
        }

        public string Learning(Dictionary<LastMatch, List<LastMatch>> matches)
        {
            return _network.Learning(matches);
        }

        public void SetLoadWeights()
        {
            _network.SetLoadWeights();
        }

        public void SaveCurrentWeights()
        {
            _network.SaveCurrentWeights();

        }

        public void ReloadWeights()
        {
            _network.ReloadWeights();
        }

        public bool ChangeDiscipline(Discipline type)
        {
            switch (type)
            {
                case Discipline.Football:
                    _network = new FootballNetwork();
                    break;
                default: break;
            }

            return true;
        }

        public List<double> GetHistoryPrediction(List<double> FullValues)
        {
            return _network.GetHistoryPrediction(FullValues);
        }

        public List<double> GetFinalPrediction(List<double> inputParameters)
        {
            return _network.GetFinalPrediction(inputParameters);
        }
    }
}
