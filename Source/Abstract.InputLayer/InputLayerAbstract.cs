using System;
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
            Console.WriteLine("Вернулось значение по умолчанию. При вызове метода GetValueForNetwork().");
            return values;
        }

        protected virtual double GetDoubleValue(List<double> OneMatch)
        {
            return 0.0;
        } 
    }

}