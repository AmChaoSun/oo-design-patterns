using System;
namespace OO_Design_Patterns.TemplateMethod
{
    public class ConcreteClassB : AbstractClass
    {
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("Implement A2");
        }
        public override void PrimitiveOperation2()
        {
            Console.WriteLine("Implement B2");
        }
    }
}