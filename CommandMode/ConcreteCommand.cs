using System;
namespace OO_Design_Patterns.CommandMode
{
    public class ConcreteCommand : AbstractCommand
    {
        public ConcreteCommand(Receiver receiver) : base(receiver)
        {
        }

        public override void Excute()
        {
            Console.WriteLine("do something");
            base.Excute();
        }
    }
}