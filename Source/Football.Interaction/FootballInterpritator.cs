using InterpritatorInterface;
using ProjectHelper;
using System;
using System.Collections.Generic;

namespace Football.Interpritator
{
    public class FootballInterpritator : IInterpritatorInterface
    {
        public FootballInterpritator()
        {}

        public bool ChangeDiscipline(Discipline type)
        {
            return true;
        }

        public List<double> GetPerfectArrayValue(int correctScorePoints)
        {
            throw new NotImplementedException();
        }

        public double GetPerfectValue(int correctScorePoints)
        {
            return SigmaFunction(correctScorePoints);
        }

        public int GetPrediction(double outputNeironResult)
        {
            var result = 0;
            var diff = outputNeironResult - SigmaFunction(0);
            while (Math.Pow(diff , 2) >= Math.Pow(outputNeironResult - SigmaFunction(result), 2)) {
                diff = outputNeironResult - SigmaFunction(result);
                result++;
            }
                
            return result - 1;
        }

        public string GetPrediction(List<double> _outOutputNeironResults)
        {
            try
            {
                int i = 0;
                while (_outOutputNeironResults.Count > i - 1)
                {
                    if (_outOutputNeironResults[i] >= 0.5) break;
                    i++;
                }
                // Нашёл I.
                return i.ToString() + (i + 1).ToString() + (i + 2).ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Метод GetPrediction() для итоговой нейросети, ошибка: " + ex.Message);
                return "Ошибка вычисления итогоого результата";
            }
        }
        
        private double SigmaFunction(double value)
        {
            double result = 2 / (1 + Math.Pow(Math.E, -5 * value)) - 1;
            return result;
        }

    }
}
 