using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Network.Football
{
    public class Neiron
    {
        private List<double> _weights;
        private const int ChangeSize = 10;
        private const int RandomSize = 5;
        private const double learningSpeed = 0.01;

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

            result = SigmaFunction(result);
            return result;
        }

        public List<double> Learning(double error, double result, List<double> output)
        {
            List<double> res = new List<double>();
            // не помню почему так
            double deltaW = Derivate(result) * error;
            for (int i = 0; i < _weights.Count; i++)
            {
                _weights[i] -= output[i] * deltaW * learningSpeed;
                res.Add(_weights[i] * deltaW);
            }

            return res;
        }

        public void ChangeWeights()
        {
            var rand = new Random();
            for (int i = 0; i < _weights.Count; i++)
                _weights[i] += rand.NextDouble() / ChangeSize;
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
            var rand = new Random();
            for (int i = 0; i < _weights.Count; i++)
                _weights[i] = rand.Next(RandomSize) + rand.NextDouble();
        }

        private double SigmaFunction(double value)
        {
            return value;
        }

        private double Derivate(double value)
        {
            return 1.0;
        }

    }
}
