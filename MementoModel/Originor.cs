using System;
namespace OO_Design_Patterns.MementoModel
{
    public class Originor
    {
        public int PropertyA { get; set; }
        public string PropertyB { get; set; }

        public Memento Save()
        {
            return new Memento(PropertyA, PropertyB);
        }

        public void Recover(Memento memento)
        {
            PropertyA = memento.PropertyA;
            PropertyB = memento.PropertyB;
        }

        public void Display()
        {
            Console.WriteLine("My PropertyA is {0}", PropertyA);
            Console.WriteLine("My PropertyB is {0}", PropertyB);
        }
    }
}