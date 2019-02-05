using System;
namespace OO_Design_Patterns.Decorator
{
    public class Person
    {
        private string name;
        public Person() { }
        public Person(string name) { this.name = name; }

        public virtual void Show()
        {
            Console.WriteLine("Decorated {0}", name);
        }
    }
}