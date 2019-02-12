using System;
namespace OO_Design_Patterns.PublishSubscribe
{
    public class NBAObserver
    {
        private string name;
        private ISubject subject;

        public NBAObserver(string name, ISubject subject)
        {
            this.name = name;
            this.subject = subject;
        }

        public void ClockNBADirectSeeding()
        {
            Console.WriteLine("{0} {1} Close NBA direct seeding.", subject.SubjectState, name);
        }
    }
}