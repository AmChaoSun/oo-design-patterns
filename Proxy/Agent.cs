namespace OO_Design_Patterns.Proxy
{
    public class Agent : IGiveGift
    {
        private Persuit boy;

        public Agent(SchoolGirl girl)
        {
            this.boy = new Persuit(girl);
        }

        public void GiveChocolate()
        {
            boy.GiveChocolate();
        }

        public void GiveDoll()
        {
            boy.GiveDoll();
        }

        public void GiveFlowers()
        {
            boy.GiveFlowers();
        }
    }
}