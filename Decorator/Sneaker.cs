using System;
namespace OO_Design_Patterns.Decorator
{
    public class Sneaker : Finery
    {
        public override void Show()
        {
            Console.Write("Sneaker ");
            base.Show();
        }
    }
}