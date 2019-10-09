using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FootBall.Network;
using INetwork;
using ProjectHelper;

namespace NetWorkController
{
    public class NetWorkController : INetworkInterface
    {
        private INetworkInterface _network;

        public NetWorkController(Discipline type)
        {
            switch (type)
            {
                case Discipline.Football:
                    _network = new FootBallNetwork();
                    break;
                default: break;
            }

        }

        /*public List<Prediction> GetPrediction(List<PastMatches> teamAMatches, List<PastMatches> teamBMatches, Tournament tournament, string[] parameters)
        {
            return _network.GetPrediction(teamAMatches, teamBMatches, tournament, parameters);
        }*/

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
                    _network = new FootBallNetwork();
                    break;
                default: break;
            }

            return true;
        }
    }
}
