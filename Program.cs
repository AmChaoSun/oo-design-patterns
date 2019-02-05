using System;
// using OO_Design_Patterns.SimpleFactory;
// using OO_Design_Patterns.Strategy;
using OO_Design_Patterns.Decorator;

namespace OO_Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Chapter 3 Decorator
            var charles = new Person("Charles");
            var sneaker = new Sneaker();
            var tShirt = new TShirt();
            sneaker.Decorate(charles);
            tShirt.Decorate(sneaker);
            tShirt.Show();
            //Chapter 2 Strategy
            // double total = 0.0d;
            // string rule = "somestring";
            // string price = null;
            // string num = null;
            // void btnOkClick(object sender, EventArgs e)
            // {
            //     CashContext cc = new CashContext(rule);
            //     double totalPrices = 0.0d;
            //     totalPrices = cc.GetResult(double.Parse(price) * double.Parse(num));
            //     total = total + totalPrices;
            // }

            // //Chapter 1 SimpleFactory
            // //Only accept +, -, *, / operations

            // Console.WriteLine("Input operator");
            // string op = Console.ReadLine();
            // var operation = OperationFactory.CreateOperation(op);

            // Console.WriteLine("Input NumA:");
            // string stringNumA = Console.ReadLine();
            // Console.WriteLine("Input NumB:");
            // string stringNumB = Console.ReadLine();
            // double numA = Convert.ToDouble(stringNumA);
            // double numB = Convert.ToDouble(stringNumB);

            // operation.NumA = numA;
            // operation.NumB = numB;
            // var result = operation.GetResult();
            // Console.WriteLine("Result is " + result);
        }
    }
}
