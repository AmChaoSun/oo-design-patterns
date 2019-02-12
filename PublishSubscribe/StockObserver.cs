using System;
namespace OO_Design_Patterns.PublishSubscribe
{
    public class StockObserver
    {
        private string name;
        private ISubject subject;

        public StockObserver(string name, ISubject subject)
        {
            this.name = name;
            this.subject = subject;
        }

        public void ClockStockMarket()
        {
            Console.WriteLine("{0} {1}Close stock market.", subject.SubjectState, name);
        }
    }
}