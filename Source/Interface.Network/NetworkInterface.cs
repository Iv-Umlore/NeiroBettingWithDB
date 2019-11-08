using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectHelper;

namespace NetworkInterface
{
    public interface INetworkInterface
    {

        List<Prediction> GetPrediction(List<LastMatch> teamAMatches, List<LastMatch> teamBMatches, TournamentShort tournament, string[] parameters);

        double TestNetwork();

        double Learning();

        void SetLoadWeights();

        void SaveCurrentWeights();

        void ReloadWeights();

        bool ChangeDiscipline(Discipline type);
    }
}
