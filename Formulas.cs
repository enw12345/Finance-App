namespace Finance_App
{
    public class Formulas
    {
        protected double presentValue;
        protected double p;
        protected double r;
        protected int t;
        protected bool convertToMonthsRate;
        protected bool convertToMonthsTime;

        protected void CheckTimePeriod(ref double r, ref int t)
        {
            if (this.convertToMonthsRate) { r = MathLib.ConvertToMonthlyRate(r); }
            if (this.convertToMonthsTime) { t = MathLib.ConvertToMonths(t); }
        }
    }
}
