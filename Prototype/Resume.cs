using System;
namespace OO_Design_Patterns.Prototype
{
    public class Resume : ICloneable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public WorkExperience Work { get; set; }
        public Resume(string name)
        {
            Name = name;
        }
        private Resume(WorkExperience work)
        {
            Work = (WorkExperience)work.Clone();
        }
        public void SetWorkExperience(WorkExperience work)
        {
            Work = work;
        }
        public void Display()
        {
            Console.WriteLine("{0} {1} {2}", Name, Age, Gender);
            Console.WriteLine("Work Experience: {0} {1}", Work.Company, Work.WorkDate);
        }

        public object Clone()
        {
            Resume obj = new Resume(Work);
            obj.Name = Name;
            obj.Gender = Gender;
            obj.Age = Age;
            return obj;
        }
    }
}