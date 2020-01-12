using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.Network
{
    public class OutputLayer
    {
        private List<double> _weights;
        private List<double> InputValueList;
        private List<double> OutputValueList;
        private List<Neiron> NeironList;
        private int _inputValuesCount;
        private int _outputValuesCount;

        public OutputLayer(int numberInputPar, int numberOutPar)
        {
            _inputValuesCount = numberInputPar;
            _outputValuesCount = numberOutPar;

            InputValueList = new List<double>();
            OutputValueList = new List<double>();

            NeironList = new List<Neiron>();

            List<double> tmp = new List<double>();
            for (int i = 0; i < numberInputPar; i++)
                tmp.Add(0.0);

            if (tmp.Count != _inputValuesCount) throw new Exception("Несоответствие размерности вектора весов и количества нейронов. OutLayer");
            for (int i = 0; i < numberOutPar; i++)
                NeironList.Add(new Neiron(tmp));
        }

        public List<double> CalculateValues(List<double> inputValues)
        {
            if (_inputValuesCount != inputValues.Count) throw new Exception("Несоответствие размерности входного вектора и количества входных параметров. OutLayer.CalculateValues()");
            InputValueList = inputValues;

            var result = new List<double>();
            foreach (var neiron in NeironList)
                result.Add(neiron.ActivationFunction(inputValues));

            if (_outputValuesCount != result.Count) throw new Exception("Несоответствие размерности выходного вектора и количества выходных параметров. OutLayer.CalculateValues()");
            OutputValueList = result;

            return result;
        }

        public List<List<double>> GetWeights()
        {
            var result = new List<List<double>>();
            foreach (var neiron in NeironList)
                result.Add(neiron.GetWeights());

            if (_outputValuesCount != result.Count) throw new Exception("Несоответствие размерности вектора весов и количества нейронов. OutLayer.GetWeights()");
            return result;
        }

        public bool SetWeights(List<List<string>> weights)
        {
            for (int i = 0; i < weights.Count; i++)
            {
                var tmp = new List<double>();
                foreach (var value in weights[i])
                    tmp.Add(double.Parse(value));
                NeironList[i].SetWeights(tmp);

            }
            return true;
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
