namespace Finance_App
{
    public class Formulas
    {
        protected double presentValue;
        protected double period;
        protected double rate;
        protected int time;
        protected bool convertToMonthsRate;
        protected bool convertToMonthsTime;

        protected void CheckTimePeriod(ref double r, ref int t)
        {
            if (this.convertToMonthsRate) { r = MathLib.ConvertToMonthlyRate(r); }
            if (this.convertToMonthsTime) { t = MathLib.ConvertToMonths(t); }
        }
    }
}
