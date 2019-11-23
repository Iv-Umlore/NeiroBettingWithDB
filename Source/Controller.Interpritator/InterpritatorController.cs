using Football.Interpritator;
using InterpritatorInterface;
using ProjectHelper;
using System.Collections.Generic;

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

        public List<double> GetPerfectArrayValue(int correctScorePoints)
        {
            return _mainInterpritator.GetPerfectArrayValue(correctScorePoints);
        }

        public double GetPerfectValue(int correctScorePoints)
        {
            return _mainInterpritator.GetPerfectValue(correctScorePoints);
        }

        public List<double> GetPrediction(double outputNeironResult)
        {
            return _mainInterpritator.GetPrediction(outputNeironResult);
        }

        public string GetPrediction(List<double> _outOutputNeironResults)
        {
            return _mainInterpritator.GetPrediction(_outOutputNeironResults);
        }
    }
}
