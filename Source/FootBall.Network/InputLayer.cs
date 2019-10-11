using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectHelper;

namespace FootBall.Network
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

        public List<double> CalculateValues(List<LastMatch> pastmatches)
        {
            return new List<double>(_outputParametersCount);
        }
    }
}
