using ProjectHelper;
using System;
using System.Collections.Generic;

namespace Football.Network
{
    public class Neiron
    {
        private List<double> _weights;
        private const int ChangeSize = 10;
        private const int RandomSize = 5;
        private const double learningSpeed = 2;

        public Neiron(List<double> weights)
        {
            _weights = new List<double>();
            _weights = weights;
        }

        public double ActivationFunction(List<double> values)
        {
            var result = 0.0;
            for (int i = 0; i < _weights.Count; i++)
                result += _weights[i] * values[i];

            result = HelpFunctions.SigmaFunction(result);
            return result;
        }

        public List<double> Learning(double error, double result, List<double> output)
        {
            List<double> res = new List<double>();
            // не помню почему так
            double deltaW = HelpFunctions.Derivate(result) * error;
            for (int i = 0; i < _weights.Count; i++)
            {
                _weights[i] -= output[i] * deltaW * learningSpeed;
                res.Add(_weights[i] * deltaW);
            }

            return res;
        }

        /// <summary>
        /// Возможно понадобиться при застое в обучении
        /// </summary>
        public void ChangeWeights()
        {

            for (int i = 0; i < _weights.Count; i++)
            {
                var coeff = (Randomaze.NextInt(2) == 1) ? 1 : -1;
                _weights[i] += Randomaze.NextDouble() * coeff / ChangeSize;
            }
        }

        public List<double> GetWeights()
        {
            return _weights;
        }

        public void SetWeights(List<double> weights)
        {
            if (weights.Count != _weights.Count) throw new Exception("Neiron. Проблема с размерностью при загрузке весов");
            _weights = weights;
        }

        public void DropWeights()
        {
            for (int i = 0; i < _weights.Count; i++)
               _weights[i] = Randomaze.NextInt(RandomSize) + Randomaze.NextDouble();
        }
        
    }
}
