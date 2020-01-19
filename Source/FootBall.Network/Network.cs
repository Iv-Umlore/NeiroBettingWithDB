using Football.InputLayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Football.Network
{
    public class Network
    {
        private string separator = ";";
        private int _inputParametersCount, _outputParametersCount;
        private FootballInputLayers _inputLayer;
        private List<HiddenLayer> _hiddenLayers;
        private OutputLayer _outputLayer;
        private string _networkName;
        /// <summary>
        /// HiddenLayerNumber - Число скрытых слоёв. Помимо них существуют Входной и Выходной слой
        /// </summary>
        /// <param name="HiddenLayerNumber"></param>
        /// <param name="inputParametersCount"></param>
        /// <param name="outputParametersCount"></param>
        /// <param name="inputParametersInLayers"></param>
        public Network(string networkName, int HiddenLayerNumber, int inputParametersCount, int outputParametersCount, List<int> inputParametersInLayers, ProjectHelper.NetworkType type)
        {
            _networkName = networkName;
            _inputParametersCount = inputParametersCount;
            _outputParametersCount = outputParametersCount;

            _inputLayer = new FootballInputLayers(_inputParametersCount, inputParametersInLayers[0], type);
            _hiddenLayers = new List<HiddenLayer>(HiddenLayerNumber);

            for (int i = 0; i < inputParametersInLayers.Count - 1; i++)
                _hiddenLayers.Add(new HiddenLayer(inputParametersInLayers[i] + 1, inputParametersInLayers[i + 1],
                    new List<List<double>>()));

            _outputLayer = new OutputLayer(inputParametersInLayers[inputParametersInLayers.Count - 1] + 1, _outputParametersCount);
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

            var listOutList = new List<List<string>>();
            foreach (var neironW in weights.Element("OutNeiron").Elements("NeironW").ToList())
                listOutList.Add(Regex.Split(neironW.Value, separator).ToList());
            _outputLayer.SetWeights(listOutList);

        }

        public void ChangeWeight()
        {
            foreach (var HL in _hiddenLayers)
                HL.ChangeWeight();

            _outputLayer.ChangeWeight();
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

            var OutWeightList = _outputLayer.GetWeights();
            var tmpOut = new XElement("OutNeiron");
            foreach (var wList in OutWeightList)
                tmpOut.Add(new XElement("NeironW", String.Join(separator, wList)));
            result.Add(tmpOut);

            return result;
        }

        public bool ReloadWeight()
        {
            foreach (var HL in _hiddenLayers)
                HL.ReloadWeights();
            _outputLayer.ReloadWeights();
            return true;
        }

        public List<double> GetPrediction(List<double> InputParameters)
        {
            // Собираем ответы по одному в кучу
            var tmpList = _inputLayer.GetValueForNetwork(InputParameters);
            foreach (var hLayer in _hiddenLayers)
            {
                tmpList = hLayer.CalculateValues(tmpList);
                // Добавляем коррекционный нейрон к ответу каждому слою
                tmpList.Add(1.0);
            }


            return _outputLayer.CalculateValues(tmpList);
        }

        /// <summary>
        /// Реализация на будущее
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private ProjectHelper.NetworkType GetNetworkTypeByName(string name)
        {
            return ProjectHelper.NetworkType.Football_Vanga;
        }

        public void Learning(object errors)
        {
            var tmp = _outputLayer.LearningLayer((List<double>)errors);
            // Удаляем изменения последнего коррекционного нейрона
            tmp.RemoveAt(tmp.Count - 1);
            for (int i = _hiddenLayers.Count - 1; i >= 0; i--)
            {
                tmp = _hiddenLayers[i].LearningLayer(tmp);
                // Удаляем изменения последнего коррекционного нейрона
                tmp.RemoveAt(tmp.Count - 1);
            }
        }

        public string NetworkName => _networkName;
    }
}
