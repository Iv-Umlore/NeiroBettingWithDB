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
        // По статистике
        List<double> GetHistoryPrediction(List<double> FullValues);

        // Итоговый
        List<double> GetFinalPrediction(List<double> inputParameters);

        string TestNetwork(Dictionary<LastMatch, List<LastMatch>> matches);

        string Learning(Dictionary<LastMatch, List<LastMatch>> matches);

        void SetLoadWeights();

        void SaveCurrentWeights(string historyFileName = "");

        void ReloadWeights();

        bool ChangeDiscipline(Discipline type);
    }
}
