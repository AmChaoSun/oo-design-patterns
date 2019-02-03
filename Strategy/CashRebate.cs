namespace OO_Design_Patterns.Strategy
{
    class CashRebate : CashSuper
    {
        private double rate = 1d;

        public CashRebate(string rate)
        {
            this.rate = double.Parse(rate);
        }

        public override double AccepetCash(double money)
        {
            return this.rate * money;
        }
    }
}