using ProjectHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpritatorInterface
{
    public interface IInterpritatorInterface
    {
        /// <summary>
        /// Вычисление. Вердикт вспомогательной нейронной сети
        /// </summary>
        int GetPrediction(double outputNeironResult);

        /// <summary>
        /// Вычисление. Строка которую надо будет распарсить для получения вердикта сети для вспомогательных сетей
        /// </summary>
        /// <param name="_outOutputNeironResults"></param>
        /// <returns></returns>
        string GetPrediction(double[] _outOutputNeironResults);

        /// <summary>
        /// Обучение. Возвращает значение, к которому должна прийти вспомогательная нейронная сеть
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        double GetPerfectValue(int correctScorePoints);

        /// <summary>
        /// Обучение. Возвращает идеальные значения выходных весов в зависимости от известного результата
        /// </summary>
        /// <param name="correctScorePoints"></param>
        /// <returns></returns>
        double[] GetPerfectArrayValue(int correctScorePoints);

        /// <summary>
        /// Смена типа интерпритатора
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        bool ChangeDiscipline(Discipline type);
    }
}
