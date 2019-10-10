using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Network.Football;

namespace FootBall.Network
{
    public class HiddenLayer
    {
        private List<double> InputValueList;
        private List<double> OutputValueList;
        private List<Neiron> NeironList;
        private int _inputValuesCount;
        private int _outputValuesCount;

        public HiddenLayer(int InputParametersCount, int NeironCount, List<List<double>> weightList)
        {
            _inputValuesCount = InputParametersCount;
            _outputValuesCount = NeironCount;

            InputValueList = new List<double>();
            OutputValueList = new List<double>();

            NeironList = new List<Neiron>(NeironCount);
            if (weightList.Count != _inputValuesCount) throw new Exception("Несоответствие размерности вектора весов и количества нейронов. Layer");
            for (int i = 0; i < NeironList.Count; i++)
                NeironList[i] = new Neiron(weightList[i]);

        }

        public List<double> CalculateValues(List<double> inputValues)
        {
            if (InputValueList.Count != inputValues.Count) throw new Exception("Несоответствие размерности входного вектора и количества входных параметров. Layer.CalculateValues()");
            InputValueList = inputValues;

            var result = new List<double>();
            foreach (var neiron in NeironList)
                result.Add(neiron.ActivationFunction(inputValues));

            if (_outputValuesCount != result.Count) throw new Exception("Несоответствие размерности выходного вектора и количества выходных параметров. Layer.CalculateValues()");
            OutputValueList = result;

            return result;
        }

        public List<List<double>> GetWeights()
        {
            var result = new List<List<double>>();
            foreach (var neiron in NeironList)
                result.Add(neiron.GetWeights());

            if (_outputValuesCount != result.Count) throw new Exception("Несоответствие размерности вектора весов и количества нейронов. Layer.GetWeights()");
            return result;
        }

        public List<double> LearningLayer(List<double> errors)
        {
            if (errors.Count != _outputValuesCount) throw new Exception("Несоответствие размерности вектора ошибок и количества нейронов. Layer.LearningLayer");
            var changeList = new List<List<double>>();
            for (int i = 0; i < errors.Count; i++)
                changeList.Add(
                    NeironList[i].Learning(errors[i], OutputValueList[i], InputValueList));

            var res = new List<double>();
            double tmp = 0;
            for (int i = 0; i < changeList[0].Count; i++)
            {
                foreach (var changeParameter in changeList)
                    tmp += changeParameter[i];
                res.Add(tmp);
                tmp = 0.0;
            }

            return res;
        }

        public void ReloadWeights()
        {
            foreach (var neiron in NeironList)
                neiron.DropWeights();
        }

    }
}
