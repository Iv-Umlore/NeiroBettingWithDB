using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ProjectHelper
{

    public static class HelpFunctions {

        public static double SigmaFunction(double value)
        {
            double result = 1 / (1 + Math.Pow(Math.E, -0.25 * value + 4));
            return result;
        }

        public static double Derivate(double value)
        {
            double E = Math.E;
            double pow = Math.Pow(E, -0.25 * value + 4);
            double result = pow / Math.Pow(1 + pow, 2);
            return result;
        }

        public static double GetMatchCoeffByTier(int tierA, int tierB)
        {
            int rankA = 21 - tierA;
            int rankB = 21 - tierB;
            var res = (double)(rankB * rankB) / (rankA * rankA);
            return res;
        }

        public static double GetCoeffByImportant(int important)
        {
            if (important == -2) return 0.7;
            if (important == -1) return 0.9;
            if (important == 0) return 1.1;
            if (important == 1) return 1.3;
            if (important == 2) return 1.5;

            return 1.0;
        }

        public static double GetCoeffByReplacement(int replasementA, int replasementB)
        {
            return 1.0;
        }

        public static double GetCoeffByTournament(int tournament_size, int tierA, int tierB)
        {
            return 1.0;
        }
        
    }

    public static class FootballHelper
    {

        private static double GausFunction(int x, int miu)
        {
            // 1 / (sqrt(0.5) * sqrt(2 * 3.1415 )) * e ^ (-(x - 6)^2/ (2*0.5))
            var deltaStep2 = 0.5;           // квадрат дельты
            var Pi = 3.14159265;            // Пи
            var ePow = -1 * Math.Pow(x - miu, 2) / (2 * deltaStep2);
            return 1 / (Math.Sqrt(deltaStep2 * 2 * Pi)) * Math.Pow(Math.E, ePow);
        }

        private static double SpecialSigmaFunction(int x, double a)
        {
            return 1 / (1 + Math.Pow(Math.E, (-x + a)));
        }

        public static List<double> GetPerfectArrayValue(int correctScorePoints)
        {
            // Вопросы
            //var sigmaParameter = -10.0;
            //while (!(SpecialSigmaFunction(correctScorePoints, sigmaParameter) < 0.73) && !(SpecialSigmaFunction(correctScorePoints, sigmaParameter) < 0.73))
            //    sigmaParameter += 0.2;

            //var result = new List<double>();
            //for (int i = 0; i < 10; i++)
            //    result.Add(SpecialSigmaFunction(i, sigmaParameter));

            var result = new List<double>();
            for (int i = 0; i < 10; i++)
                result.Add(GausFunction(i, correctScorePoints));

            return result;
        }

        public static double GetPerfectValue(int correctScorePoints)
        {
            return HelpFunctions.SigmaFunction(correctScorePoints);
        }

        public static List<double> GetVangaInputParametersByCorrectMarchForFootballLearning(LastMatch LM)
        {
            return new List<double>()
                    {
                        // Total
                        LM.Score_A +  LM.Score_B,
                        LM.Score_A + LM.Score_B + 1,
                        // Save A
                        LM.save_A / (LM.shot_on_target_B + 1),
                        ( LM.shot_on_target_B == 0)? 0.8 : LM.save_A / LM.shot_on_target_B,
                        // Save B
                        LM.save_B / (LM.shot_on_target_A + 1),
                        (LM.shot_on_target_A == 0) ? 0.8 : LM.save_B / LM.shot_on_target_A,
                        // Нарушения А
                        LM.Violations_A,
                        LM.Violations_A + 1,
                        // Нарушения В
                        LM.Violations_B,
                        LM.Violations_B + 1,
                        // Shot A
                        LM.shot_on_target_A,
                        LM.shot_on_target_A + 1,
                        // Shot B
                        LM.shot_on_target_B,
                        LM.shot_on_target_B + 1
                    };
        }

        public static List<double> GetCurrectParametersForHelperLearning(LastMatch LM)
        {
            return new List<double>()
                    {
                        // Total
                        HelpFunctions.SigmaFunction(LM.Score_A +  LM.Score_B),
                        // Save A
                        (LM.shot_on_target_B == 0)? 0.75 : LM.save_A / LM.shot_on_target_B,
                        // Save B
                        (LM.shot_on_target_A == 0)? 0.75 : LM.save_B / LM.shot_on_target_A,
                        // Нарушения А
                        HelpFunctions.SigmaFunction(LM.Violations_A),
                        // Нарушения В
                        HelpFunctions.SigmaFunction(LM.Violations_B),
                        // Shot A
                        HelpFunctions.SigmaFunction(LM.shot_on_target_A),
                        // Shot B
                        HelpFunctions.SigmaFunction(LM.shot_on_target_B),
                    };
        }
    }

    public static class Randomaze
    {
        private static Random rand;

        static Randomaze()
        {
            rand = new Random((int)DateTime.Now.Ticks);
        }

        public static int NextInt(int maxSize)
        {
            return rand.Next(maxSize);
        }

        public static double NextDouble()
        {
            return rand.NextDouble();
        }

    }

}