using System.Collections.Generic;
using ProjectHelper;

namespace Football.Network
{
    public class InputLayer
    {
        private int _numberInputParametersCount, _outputParametersCount;
        private double[] outputParameters;

        public InputLayer(int numberParametersCount, int outputParametersCount)
        {
            _numberInputParametersCount = numberParametersCount;
            _outputParametersCount = outputParametersCount;
            outputParameters = new double[_outputParametersCount];
        }

        public List<double> CalculateValues(List<double> staticsticValues, List<int> importantValues)
        {
            return new List<double>(_outputParametersCount);
        }
    }
}
