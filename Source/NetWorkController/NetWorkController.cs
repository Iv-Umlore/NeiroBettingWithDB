using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INetwork;
using Network.Football;
using ProjectHelper;

namespace NetWorkController
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

        public List<Prediction> GetPrediction(List<LastMatch> teamAMatches, List<LastMatch> teamBMatches, TournamentShort tournament, string[] parameters)
        {
            return _network.GetPrediction(teamAMatches, teamBMatches, tournament, parameters);
        }

        public double TestNetwork()
        {
            return _network.TestNetwork();
        }

        public double Learning()
        {
            return _network.Learning();
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
    }
}
