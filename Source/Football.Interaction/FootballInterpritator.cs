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
            return HelpFunctions.SigmaFunction(correctScorePoints);
        }

        /// <summary>
        /// Возвращает 2 значения - наиболее соответствующие принятым обозначениям
        /// Применимо для вспомогательных сетей
        /// </summary>
        /// <param name="outputNeironResult"></param>
        /// <returns></returns>
        public List<double> GetPrediction(double outputNeironResult)
        {
            // В дальнейшем возможно заменить сигма-функцию
            List<double> res = new List<double>();
            var result = 0;

            var diff = outputNeironResult - HelpFunctions.SigmaFunction(result);
            result++;
            while (Math.Pow(diff , 2) > Math.Pow(outputNeironResult - HelpFunctions.SigmaFunction(result), 2)) { 
                diff = outputNeironResult - HelpFunctions.SigmaFunction(result);
                result++;
            }
            

            var prev = Math.Pow(outputNeironResult - HelpFunctions.SigmaFunction(((result - 2) < 0) ? 0 : result - 2), 2);
            var next = Math.Pow(outputNeironResult - HelpFunctions.SigmaFunction(result), 2);

            bool flag = ( prev < next);

            if (flag) {
                res.Add( ( result - 2 < 0) ? 0 : result - 2);
                res.Add( ( result - 1 < 0) ? 0 : result - 1 );
            }
            else {                
                res.Add((result - 1 < 0) ? 0 : result - 1 );
                res.Add(result);
            }

            return res;
        }

        /// <summary>
        /// Возвращает итоговый прогноз нейросети в зависимости от входных 10 чисел
        /// </summary>
        /// <param name="_outOutputNeironResults"></param>
        /// <returns></returns>
        public string GetPrediction(List<double> _outOutputNeironResults)
        {
            try
            {
                int i = 0;
                while (_outOutputNeironResults.Count > i - 1)
                {
                    if (_outOutputNeironResults[i] >= 0.75) break;
                    i++;
                }
                // Нашёл I.
                return i.ToString() + (i + 1).ToString() + (i + 2).ToString();
                // Добавить дополнительный интерпритатор для преобразования в нормальную понятную строку
            }
            catch (Exception ex)
            {
                Console.WriteLine("Метод GetPrediction() для итоговой нейросети, ошибка: " + ex.Message);
                return "Ошибка вычисления итогоого результата";
            }
        }
        
    }
}
 