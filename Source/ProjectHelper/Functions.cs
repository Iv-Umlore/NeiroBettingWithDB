﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ProjectHelper
{

    public static class HelpFunctions {

        public static double SigmaFunction(double value)
        {
            double result = 1 / (1 + Math.Pow(5 * Math.E, -value));
            return result;
        }

        public static double Derivate(double value)
        {
            double E = Math.E;
            double pow = Math.Pow(E, -value);
            double result = 5 * pow / Math.Pow(1 + 5 * pow, 2);
            return result;
        }

        public static double GetMatchCoeffByTier(int tierA, int tierB)
        {
            int rankA = 21 - tierA;
            int rankB = 21 - tierB;
            return (rankB * rankB) / (rankA * rankA);
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