using System;
namespace OO_Design_Patterns.Facade
{
    public class Facade
    {
        SubSystemOne one;
        SubSystemTwo two;
        SubSystemThree three;
        SubSystemFour four;
        public Facade()
        {
            one = new SubSystemOne();
            two = new SubSystemTwo();
            three = new SubSystemThree();
            four = new SubSystemFour();
        }

        public void MethodA()
        {
            Console.WriteLine("This is method set A");
            one.MethodOne();
            two.MethodTwo();
        }

        public void MethodB()
        {
            Console.WriteLine("This is method set B");
            three.MethodThree();
            four.MethodFour();
        }
    }
}