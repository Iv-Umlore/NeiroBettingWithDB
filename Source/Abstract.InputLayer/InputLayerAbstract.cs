using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.InputLayer
{
    public abstract class InputLayerAbstract
    {
        int _inputParametersCount;
        int _outputParametersCount;

        public InputLayerAbstract(int inputParametersCount, int outputParametersCount)
        {
            _inputParametersCount = inputParametersCount;
            _outputParametersCount = outputParametersCount;
        }
    }
}
