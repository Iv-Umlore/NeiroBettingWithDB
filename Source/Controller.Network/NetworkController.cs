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
        
        public double TestNetwork()
        {
            return _network.TestNetwork();
        }

        public double Learning()
        {
            return _network.Learning();
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

        public List<double> GetHistoryPrediction(List<LastMatch> teamAMatches, List<LastMatch> teamBMatches, TournamentShort tournament, string[] parameters)
        {
            return _network.GetHistoryPrediction(teamAMatches, teamBMatches, tournament, parameters);
        }

        public List<double> GetFinalPrediction(List<int> inputParameters)
        {
            return _network.GetFinalPrediction(inputParameters);
        }
    }
}
