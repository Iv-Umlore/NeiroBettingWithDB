using Football.Interpritator;
using InterpritatorInterface;
using ProjectHelper;

namespace InterpritatorController
{
    public class InterpritatorController : IInterpritatorInterface
    {
        IInterpritatorInterface _mainInterpritator;

        public InterpritatorController(Discipline type)
        {
            switch (type)
            {
                case Discipline.Football:
                    _mainInterpritator = new FootballInterpritator();
                    break;
                default: break;
            }
            
        }

        public bool ChangeDiscipline(Discipline type)
        {
            switch (type)
            {
                case Discipline.Football:
                    _mainInterpritator = new FootballInterpritator();
                    break;
                default: break;
            }

            return true;
        }

        public double[] GetPerfectArrayValue(int correctScorePoints)
        {
            return _mainInterpritator.GetPerfectArrayValue(correctScorePoints);
        }

        public double GetPerfectValue(int correctScorePoints)
        {
            return _mainInterpritator.GetPerfectValue(correctScorePoints);
        }

        public int GetPrediction(double outputNeironResult)
        {
            return _mainInterpritator.GetPrediction(outputNeironResult);
        }

        public string GetPrediction(double[] _outOutputNeironResults)
        {
            return GetPrediction(_outOutputNeironResults);
        }
    }
}
