using System;
namespace OO_Design_Patterns.State
{
    public class ConcreteStateB : State
    {
        public override void Handle(Context context)
        {
            Console.WriteLine("Handle method B");
        }
    }
}