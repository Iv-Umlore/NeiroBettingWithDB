using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using FootBall.Network;
using ProjectHelper;

namespace Network.Football
{
    public class Network
    {
        private string separator = ";";
        private int _inputParametersCount, _outputParametersCount;
        private InputLayer _inputLayer;
        private List<HiddenLayer> _hiddenLayers;
        //private OutputLayer _outputLayer;
        private string _networkName;
        /// <summary>
        /// HiddenLayerNumber - Число скрытых слоёв. Помимо них существуют Входной и Выходной слой
        /// </summary>
        /// <param name="HiddenLayerNumber"></param>
        /// <param name="inputParametersCount"></param>
        /// <param name="outputParametersCount"></param>
        /// <param name="inputParametersInLayers"></param>
        public Network(string networkName, int HiddenLayerNumber, int inputParametersCount, int outputParametersCount, List<int> inputParametersInLayers)
        {
            _networkName = networkName;
            _inputParametersCount = inputParametersCount;
            _outputParametersCount = outputParametersCount;

            _inputLayer = new InputLayer(_inputParametersCount, inputParametersInLayers[0]);
            _hiddenLayers = new List<HiddenLayer>(HiddenLayerNumber);

            for (int i = 0; i < inputParametersInLayers.Count - 1; i++)
            {
                _hiddenLayers.Add(new HiddenLayer(inputParametersInLayers[i], inputParametersInLayers[i + 1],
                    new List<List<double>>()));
            }

            // _outputLayer = new OutputLayer(inputParametersInLayers[inputParametersInLayers.Count-1],_outputParametersCount);
            // OUTPUT ЕСТЬ
        }

        public void SetLoadWeight(XElement weights)
        {
            var elements = weights.Elements("Neiron").ToList();

            for (int i = 0; i < _hiddenLayers.Count; i++)
            {
                var listList = new List<List<string>>();
                foreach (var neironW in elements[i].Elements("NeironW").ToList())
                    listList.Add(Regex.Split(neironW.Value, separator).ToList());

                _hiddenLayers[i].SetWeights(listList);
            }

            // OUTPUT ЕСТЬ

        }

        public XElement GetXmlWeights()
        {
            XElement result = new XElement(_networkName, 0);
            for (int i = 0; i < _hiddenLayers.Count; i++)
            {
                var weightList = _hiddenLayers[i].GetWeights();
                var tmp = new XElement("Neiron", i);
                foreach (var wList in weightList)
                    tmp.Add(new XElement("NeironW", String.Join(separator, wList)));
                result.Add(tmp);
            }

            // OUTPUT ЕСТЬ

            return result;
        }

        public bool ReloadWeight()
        {
            foreach (var HL in _hiddenLayers)
                HL.ReloadWeights();
            return true;
        }

        public List<double> GetPrediction(List<List<double>> InputParameters)
        {
            return new List<double>(_outputParametersCount);
        }

        public string NetworkName => _networkName;
    }
}
