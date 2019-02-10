using System;
using System.Linq;

namespace ITS_KoefShortlifa
{
    public class CalculatorService
    {
        public double GetValue(params double[] values)
        {
            int counter = values.Where(x => x != 0).Count();
            var result = values.Sum() / counter;
            return Math.Round(result, 3);
        }

        public double GetNewValue(double oldValue, double e1, double e2)
        {
            var shortlif = e1 + e2 * (1 - e1);
            var value = oldValue * shortlif;
            return Math.Round(value, 3);
        }

        public double GetMax(params double[] values)
        {
            return values.Max();
        }
    }
}
