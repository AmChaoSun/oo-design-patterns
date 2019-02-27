using System;

namespace OO_Design_Patterns.BridgeMode
{
    public class ConcreteImplementor : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("Some Operation");
        }
    }
}