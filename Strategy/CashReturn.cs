using System;
namespace OO_Design_Patterns.Strategy
{
    class CashReturn : CashSuper
    {
        private double moneyCondition = 0d;
        private double moneyReturn = 0d;

        public CashReturn(string moneyCondition, string moneyReturn)
        {
            this.moneyCondition = double.Parse(moneyCondition);
            this.moneyReturn = double.Parse(moneyReturn);
        }
        public override double AccepetCash(double money)
        {
            if (money >= moneyReturn)
            {
                return money - Math.Floor(money / moneyCondition) * moneyReturn;
            }
            return money;
        }
    }
}