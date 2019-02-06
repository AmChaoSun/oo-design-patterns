using System;
namespace OO_Design_Patterns.Proxy
{
    public class Persuit : IGiveGift
    {
        private SchoolGirl girl;
        public Persuit(SchoolGirl girl)
        {
            this.girl = girl;
        }
        public void GiveChocolate()
        {
            Console.WriteLine(girl.Name + " give you chocolate");
        }

        public void GiveDoll()
        {
            Console.WriteLine(girl.Name + " give you doll");
        }

        public void GiveFlowers()
        {
            Console.WriteLine(girl.Name + " give you flowers");
        }
    }
}