using Abstract.InputLayer;
using ProjectHelper;
using System.Collections.Generic;

namespace Football.InputLayers
{
    public class FootballInputLayers : InputLayerAbstract
    {
        public FootballInputLayers(int inputParametersCount, int outputParametersCount, NetworkType nType) : base(inputParametersCount, outputParametersCount, nType) { }

        public override List<double> GetValueForNetwork(List<double> values)
        {
            switch (_networkT)
            {
                case NetworkType.Football_Total: return GetStaticsticTotalGoal(values);
                case NetworkType.Football_SaveA: return GetStatisticSaveA(values);
                case NetworkType.Football_SaveB: return GetStatisticSaveB(values);
                case NetworkType.Football_ViolationsA: return GetStatisticViolationsA(values);
                case NetworkType.Football_ViolationsB: return GetStatisticViolationsB(values);
                case NetworkType.Football_ShotA: return GetStatisticShotA(values);
                case NetworkType.Football_ShotB: return GetStatisticShotB(values);
                case NetworkType.Football_Vanga: return GetVangaInput(values);
                default: return base.GetValueForNetwork(values);
            }        
            
        }

        protected override double GetDoubleValue(List<double> OneMatch)
        {
            return 0.0;
        }

        private List<double> GetStatisticTotalGoals(List<double> values)
        {
            var result = new List<double>();
            int i = 0;
            while (i < values.Count)
            {
                var tierCoeff = HelpFunctions.GetMatchImportandCoeff((int)values[8], (int)values[9]);
                var importantCoeff = HelpFunctions.GetCoeffByImportant((int)values[10] - (int)values[11]);
                var replasementCoeff = HelpFunctions.GetCoeffByReplacement((int)values[12], (int)values[13]);
                var tmp = (values[0] + values[1]) * tierCoeff * importantCoeff * replasementCoeff;
                result.Add(tmp);
            }

            return result;
        }
        private List<double> GetStatisticSaveA(List<double> values)
        {
            return new List<double>(_outputParametersCount);
        }
        private List<double> GetStatisticSaveB(List<double> values)
        {
            return new List<double>(_outputParametersCount);
        }
        private List<double> GetStatisticViolationsA(List<double> values)
        {
            return new List<double>(_outputParametersCount);
        }
        private List<double> GetStatisticViolationsB(List<double> values)
        {
            return new List<double>(_outputParametersCount);
        }
        private List<double> GetStatisticShotA(List<double> values)
        {
            return new List<double>(_outputParametersCount);
        }
        private List<double> GetStatisticShotB(List<double> values)
        {
            return new List<double>(_outputParametersCount);
        }
        private List<double> GetStaticsticTotalGoal(List<double> values)
        {
            return new List<double>(_outputParametersCount);
        }
        private List<double> GetVangaInput(List<double> values)
        {
            return new List<double>(_outputParametersCount);
        }
    }
}
