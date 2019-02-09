using System;
namespace OO_Design_Patterns.TemplateMethod
{
    public class ConcreteClassA : AbstractClass
    {
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("Implement A1");
        }
        public override void PrimitiveOperation2()
        {
            Console.WriteLine("Implement B1");
        }
    }
}