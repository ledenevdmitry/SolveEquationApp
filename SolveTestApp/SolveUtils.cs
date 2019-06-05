using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics;

namespace SolveTestApp
{
    class SolveUtils
    {
        //10^(-10) - точность для отбрасывания комплексных чисел
        static double accuracy = 1E-10;

        // Решает уравнение −ξz0 + ηa − (ξλ1^2z0)a^2 + (ηλ1λ2)a^3 = 0 относительно "a"
        public static IEnumerable<double> SolveEquation(double eta, double lambda1, double lambda2, double xi, double z)
        {
            if (!lambda1.AlmostEqual(0))
            {
                // FindRoots.Cubic находит все (и комплексные) корни уравнения вида d + c*x + b*x^2 + a*x^3 = 0
                var allRoots = FindRoots.Cubic(-xi * z, eta, -lambda1 * lambda1 * xi * z, eta * lambda1 * lambda2);

                //отбрасываем комплесные корни (мнимая часть бывает очень маленькой, но ненулевой, тк считаем на double)
                if (allRoots.Item1.Imaginary.AlmostEqual(0)) yield return allRoots.Item1.Real;
                if (allRoots.Item2.Imaginary.AlmostEqual(0)) yield return allRoots.Item2.Real;
                if (allRoots.Item3.Imaginary.AlmostEqual(0)) yield return allRoots.Item3.Real;
            }
            else
            {
                yield return xi * z / eta;
            }
        }

        //делаем табличку "значение z - значения a"
        public static List<Tuple<double, IEnumerable<double>>> TableOfRoots(double eta, double lambda1, double lambda2, double xi, double h, double step)
        {
            var pairs = new List<Tuple<double, IEnumerable<double>>>();
            for(double z = -h; z < h; z += step)
            {
                pairs.Add(new Tuple<double, IEnumerable<double>>(z, SolveEquation(eta, lambda1, lambda2, xi, z)));
            }
            return pairs;
        }

        public static List<Tuple<double, double>> DerivativeToFunction(double k, double xi, double h, List<Tuple<double, IEnumerable<double>>> derivativePairs)
        {
            double wMinusH = -k * xi * h;
            double sum = wMinusH;
            double prev = -h;

            var pairs = new List<Tuple<double, double>>();

            foreach(var pair in derivativePairs)
            {
                sum += (pair.Item1 - prev) * pair.Item2.First();
                pairs.Add(new Tuple<double, double>(pair.Item1, sum));

                prev = pair.Item1;
            }

            return pairs;
        }
    }
}
