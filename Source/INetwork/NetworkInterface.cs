﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectHelper;

namespace INetwork
{
    public interface INetworkInterface
    {

        //List<Prediction> GetPrediction(List<PastMatches> teamAMatches, List<PastMatches> teamBMatches, Tournament tournament, string[] parameters);

        double TestNetwork();

        double Learning();

        void SaveCurrentWeights();

        void ReloadWeights();

        bool ChangeDiscipline(Discipline type);
    }
}
