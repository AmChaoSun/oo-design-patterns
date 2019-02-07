namespace OO_Design_Patterns.Factory
{
    public class UndergraduateFactory : IFactory
    {
        public GoodMan CreateGoodMan()
        {
            return new Undergraduate();
        }
    }
}