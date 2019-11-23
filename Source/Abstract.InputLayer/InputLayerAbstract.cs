using ProjectHelper;
using System.Collections.Generic;

namespace Abstract.InputLayer
{
    public abstract class InputLayerAbstract
    {
        protected int _inputParametersCount;
        protected int _outputParametersCount;
        protected NetworkType _networkT;

        public InputLayerAbstract(int inputParametersCount, int outputParametersCount, NetworkType nType)
        {
            _inputParametersCount = inputParametersCount;
            _outputParametersCount = outputParametersCount;
            _networkT = nType;
        }

        public virtual List<double> GetValueForNetwork(List<double> values) {
            return new List<double>();
        }

        protected virtual double GetDoubleValue(List<double> OneMatch)
        {
            return 0.0;
        } 
    }

}