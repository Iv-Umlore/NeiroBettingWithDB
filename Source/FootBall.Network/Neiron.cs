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
        private double result;
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
            result = 0.0;
            for (int i = 0; i < _weights.Count; i++)
                result += _weights[i] * values[i];

            result = SigmaFunction(result);
            return result;
        }

        public List<double> Learning(double error, List<double> output)
        {
            List<double> res = new List<double>();
            // нен помню почему так
            double deltaW = Derivate(result) * error;
            for (int i = 0; i < _weights.Count; i++)
            {
                _weights[i] -= output[i] * deltaW * learningSpeed;
                res.Add(_weights[i] * deltaW);
            }

            return new List<double>();
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
