using System;
namespace OO_Design_Patterns.CompositeMode
{
    public class HRDepartment : Company
    {
        public HRDepartment(string name) : base(name) { }
        public override void Add(Company c)
        {
            throw new System.NotImplementedException();
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);
        }

        public override void LineOfDuty()
        {
            Console.WriteLine("{0} Employee management", name);
        }

        public override void Remove(Company c)
        {
            throw new System.NotImplementedException();
        }
    }
}