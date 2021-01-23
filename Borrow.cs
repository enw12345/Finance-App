using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance_App
{
    public class Borrow : Formulas
    {
        public Borrow(double p, double r, int t, bool ctmr, bool ctmt)
        {
            this.p = p;
            this.r = r;
            this.t = t;

            this.convertToMonthsRate = ctmr;
            this.convertToMonthsTime = ctmt;
        }

        public double AmortizedLoanPayment(double p, double r, int t)
        {
            CheckTimePeriod(ref r, ref t);
            double rDouble = MathLib.ConvertToDecimal(r);
            double b2 = Math.Pow(1 + rDouble, t);
            return p / ((b2 - 1) / (rDouble * b2));
        }

        public double InterestOnlyLoanPayment(double a, float rate, int n)
        {
            return 0;
        }
    }
}
