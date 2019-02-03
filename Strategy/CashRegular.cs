namespace OO_Design_Patterns.Strategy
{
    class CashRegular : CashSuper
    {
        public override double AccepetCash(double money)
        {
            return money;
        }
    }
}