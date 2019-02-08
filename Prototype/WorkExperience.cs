using System;
namespace OO_Design_Patterns.Prototype
{
    public class WorkExperience : ICloneable
    {
        public string Company { get; set; }
        public string WorkDate { get; set; }

        public WorkExperience() { }
        public WorkExperience(string company, string workDate)
        {
            Company = company;
            WorkDate = workDate;
        }

        public object Clone()
        {
            return (Object)this.MemberwiseClone();
        }
    }
}