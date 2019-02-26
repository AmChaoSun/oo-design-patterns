using System;
using System.Collections.Generic;

namespace OO_Design_Patterns.CompositeMode
{
    public class ConcreteCompany : Company
    {
        private List<Company> children = new List<Company>();
        public ConcreteCompany(string name) : base(name) { }

        public override void Add(Company c)
        {
            children.Add(c);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);
            foreach (var child in children)
            {
                child.Display(depth + 2);
            }
        }

        public override void LineOfDuty()
        {
            foreach (var child in children)
            {
                child.LineOfDuty();
            }
        }

        public override void Remove(Company c)
        {
            children.Remove(c);
        }
    }
}