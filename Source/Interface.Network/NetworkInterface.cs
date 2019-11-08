﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectHelper;

namespace NetworkInterface
{
    public interface INetworkInterface
    {
        // По статистике
        List<double> GetHistoryPrediction(List<LastMatch> teamAMatches, List<LastMatch> teamBMatches, TournamentShort tournament, string[] parameters);

        // Итоговый
        List<double> GetFinalPrediction(List<int> inputParameters);

        double TestNetwork();

        double Learning();

        void SetLoadWeights();

        void SaveCurrentWeights();

        void ReloadWeights();

        bool ChangeDiscipline(Discipline type);
    }
}
