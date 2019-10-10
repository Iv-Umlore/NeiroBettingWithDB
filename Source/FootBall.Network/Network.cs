using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FootBall.Network;
using ProjectHelper;

namespace Network.Football
{
    public class Network
    {
        private int _inputParametersCount, _outputParametersCount;
        private InputLayer _inputLayer;
        private List<HiddenLayer> _hiddenLayers;
        // private OutputLayer _outputLayer;
        /// <summary>
        /// HiddenLayerNumber - Число скрытых слоёв. Помимо них существуют Входной и Выходной слой
        /// </summary>
        /// <param name="HiddenLayerNumber"></param>
        /// <param name="inputParametersCount"></param>
        /// <param name="outputParametersCount"></param>
        /// <param name="inputParametersInLayers"></param>
        public Network(int HiddenLayerNumber, int inputParametersCount, int outputParametersCount, List<int> inputParametersInLayers)
        {
            _inputParametersCount = inputParametersCount;
            _outputParametersCount = outputParametersCount;

            _inputLayer = new InputLayer(120, inputParametersInLayers[0]);

            for (int i = 0; i < inputParametersInLayers.Count - 1; i++)
                _hiddenLayers.Add(new HiddenLayer(inputParametersInLayers[i], inputParametersInLayers[i + 1], new List<List<double>>()));

            // _outputLayer = new OutputLayer(inputParametersInLayers[inputParametersInLayers.Count-1],_outputParametersCount);

        }

        public List<double> GetPrediction(List<List<double>> InputParameters)
        {
            return new List<double>(_outputParametersCount);
        }
    }
}
