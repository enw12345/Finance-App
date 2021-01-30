using System;

namespace Finance_App
{
    public class Borrow : Formulas
    {
        public Borrow(double p, double r, int t, bool ctmr, bool ctmt)
        {
            period = p;
            rate = r;
            time = t;

            convertToMonthsRate = ctmr;
            convertToMonthsTime = ctmt;
        }

        public double AmortizedLoanPayment(double p, double r, int t)
        {
            CheckTimePeriod(ref r);
            double rateDecimal = MathLib.ConvertToDecimal(r);
            double b2 = Math.Pow(1 + rateDecimal, t);
            return p / ((b2 - 1) / (rateDecimal * b2));
        }

        public double InterestOnlyLoanPayment(double a, float rate, int n)
        {
            return 0;
        }
    }
}
