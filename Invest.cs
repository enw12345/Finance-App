using System;

namespace Finance_App
{
    public class Invest : Formulas
    {
        private double presentValue;

        public Invest(double presentValue, double p, double r, int t, bool ctmr, bool ctmt)
        {
            this.presentValue = presentValue;
            this.p = p;
            this.r = r;
            this.t = t;

            this.convertToMonthsRate = ctmr;
            this.convertToMonthsTime = ctmt;
        }

        /// <summary>
        /// Interest accrued over a period of time
        /// </summary>
        /// <param name="p">period</param>
        /// <param name="r">rate</param>
        /// <param name="t">time</param>
        /// <returns>Simple Interest</returns>
        public double SimpleInterest(double p, double r, int t)
        {
            CheckTimePeriod(ref r, ref t);
            double rDouble = MathLib.ConvertToDecimal(r);
            return p * rDouble * t;
        }

        /// <summary>
        /// Future Value with simple interest is the ending balance after plus the simple intrest
        /// </summary>
        /// <param name="p">principal</param>
        /// <param name="r">rate</param>
        /// <param name="t">time period</param>
        /// <returns>Future value with Simple Interest</returns>
        public double FutureValueWithSimpleInterest(double p, double r, int t)
        {
            CheckTimePeriod(ref r, ref t);
            double rDouble = MathLib.ConvertToDecimal(r);
            return p * (1 + rDouble * t);
        }

        /// <summary>
        /// Interest accrued over a period of time where the amount earned is reinvested 
        /// </summary>
        /// <param name="p">period</param>
        /// <param name="r">rate</param>
        /// <param name="time">time</param>
        /// <returns>compound interes</returns>
        public double CompoundInterest(double p, double r, int t)
        {
            CheckTimePeriod(ref r, ref t);
            double rDouble = MathLib.ConvertToDecimal(r);
            double a = Math.Pow((1 + rDouble), t);
            return p * (a - 1);
        }

        /// <summary>
        /// Future Value with compound interest is the ending balance plus the compound intrest
        /// </summary>
        /// <param name="p">period</param>
        /// <param name="r">rate</param>
        /// <param name="time">time</param>
        /// <returns>compound interets</returns>
        public double FutureValueWithCompoundInterest(double p, double r, int t)
        {
            CheckTimePeriod(ref r, ref t);
            double rDouble = MathLib.ConvertToDecimal(r);
            return p * Math.Pow((1 + rDouble), t);
        }

        /// <summary>
        /// Calculates the ending balance for a periodic series of payments
        /// </summary>
        /// <param name="p">principal</param>
        /// <param name="r">rate</param>
        /// <param name="t">time period</param>
        /// <returns></returns>
        public double FutureValueOfAnnuity(double p, double r, int t)
        {
            CheckTimePeriod(ref r, ref t);
            double rDouble = MathLib.ConvertToDecimal(r);
            double num = (Math.Pow(1 + rDouble, t)) - 1;
            return p * (num / rDouble);
        }

        public double FutureValue(double presentValue, double p, double r, int t)
        {
            return FutureValueOfAnnuity(p, r, t) + FutureValueWithCompoundInterest(presentValue, r, t);
        }
    }
}
