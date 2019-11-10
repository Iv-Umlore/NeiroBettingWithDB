using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.InputLayer
{
    public abstract class InputLayerAbstract
    {
        private int _inputParametersCount;
        private int _outputParametersCount;

        public InputLayerAbstract(int inputParametersCount, int outputParametersCount)
        {
            _inputParametersCount = inputParametersCount;
            _outputParametersCount = outputParametersCount;
        }


        public virtual List<double> GetValueForNetwork(List<int> values) {
            return new List<double>();
        }
    }

}