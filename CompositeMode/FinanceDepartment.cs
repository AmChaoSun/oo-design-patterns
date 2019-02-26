using System;
namespace OO_Design_Patterns.CompositeMode
{
    public class FinanceDepartment : Company
    {
        public FinanceDepartment(string name) : base(name) { }

        public override void Add(Company c)
        {
            throw new NotImplementedException();
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);
        }

        public override void LineOfDuty()
        {
            Console.WriteLine("{0} income/outcome management", name);
        }

        public override void Remove(Company c)
        {
            throw new NotImplementedException();
        }
    }
}