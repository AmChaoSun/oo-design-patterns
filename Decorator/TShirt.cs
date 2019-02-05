using System;
namespace OO_Design_Patterns.Decorator
{
    public class TShirt : Finery
    {
        public override void Show()
        {
            Console.Write("Big TShirt ");
            base.Show();
        }
    }
}