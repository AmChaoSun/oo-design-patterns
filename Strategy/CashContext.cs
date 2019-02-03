namespace OO_Design_Patterns.Strategy
{
    class CashContext
    {
        CashSuper cs = null;
        public CashContext(string rule)
        {
            switch (rule)
            {
                case "Regular":
                    cs = new CashRegular();
                    break;
                case "Rebate 20%":
                    cs = new CashRebate("0.8");
                    break;
                case "300 Return 100":
                    cs = new CashReturn("300", "100");
                    break;
                default:
                    cs = new CashRegular();
                    break;
            }
        }

        public double GetResult(double money)
        {
            return cs.AccepetCash(money);
        }
    }
}