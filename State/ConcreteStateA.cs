using System;
namespace OO_Design_Patterns.State
{
    public class ConcreteStateA : State
    {
        public override void Handle(Context context)
        {
            Console.WriteLine("Handle method A");
        }
    }
}