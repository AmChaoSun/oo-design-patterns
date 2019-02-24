using System;
// using OO_Design_Patterns.SimpleFactory;
// using OO_Design_Patterns.Strategy;
// using OO_Design_Patterns.Decorator;
// using OO_Design_Patterns.Proxy;
// using OO_Design_Patterns.Factory;
// using OO_Design_Patterns.Prototype;
// using OO_Design_Patterns.TemplateMethod;
// using OO_Design_Patterns.Facade;
// using OO_Design_Patterns.Builder;
// using OO_Design_Patterns.PublishSubscribe;
// using OO_Design_Patterns.AdapterModel;
// using OO_Design_Patterns.MementoModel;
using OO_Design_Patterns.Sort;

namespace OO_Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] arr1 = new int[] { 1, 5, 6, 3, 4, 19, 2 };
            int[] arr2 = new int[] { 8, 1, 12, 7, 9, 21, 3 };

            ISort mySort1 = new QuickSort(arr1);
            mySort1.Display();
            mySort1.AscendSort();
            mySort1.Display();

            ISort mySort2 = new QuickSort(arr2);
            mySort2.Display();
            mySort2.AscendSort();
            mySort2.Display();
            // // Chapter 18 Memento Model
            // // init
            // Originor originor = new Originor()
            // {
            //     PropertyA = 123,
            //     PropertyB = "Unchanged"
            // };
            // originor.Display();

            // // save
            // CareTaker c = new CareTaker();
            // c.Memento = originor.Save();

            // //change
            // originor.PropertyA = 456;
            // originor.PropertyB = "Changed";
            // originor.Display();

            // // recover
            // originor.Recover(c.Memento);
            // originor.Display();

            // //Chapter 17 Adapter Model
            // ITarget target = new Adapter();
            // target.Request();

            //Chapter 15 Reflection and dependency injection
            //The method on book is old. Now I use constructor and autofac to fix it.


            // // Chapter 14 Publish/Subscribe and delegate

            // // create publisher and subscriptions
            // Boss charles = new Boss();
            // StockObserver julie = new StockObserver("Julie", charles);
            // NBAObserver zak = new NBAObserver("Zak", charles);

            // // bind event
            // charles.Update += new Boss.EventHandler(julie.ClockStockMarket);
            // charles.Update += new Boss.EventHandler(zak.ClockNBADirectSeeding);

            // //trigger
            // charles.SubjectState = "Charles is coming";
            // charles.Notify();



            // // Chapter 13 Builder
            // Builder.Builder builderA = new ConcreteBuilderA();
            // Builder.Builder builderB = new ConcreteBuilderB();

            // Director.Construct(builderA);
            // Product pA = builderA.GetProduct();
            // pA.Show();

            // Director.Construct(builderB);
            // Product pB = builderB.GetProduct();
            // pB.Show();



            // // Chapter 12 Facade
            // var facade = new Facade.Facade();

            // facade.MethodA();
            // facade.MethodB();

            // Chapter 9 Prototype
            // Resume charles = new Resume("Charles");
            // charles.Age = 25;
            // charles.Gender = "Male";
            // charles.Work = new WorkExperience("Google", "2018-2020");
            // charles.Display();

            // Resume charlesV1 = (Resume)charles.Clone();
            // charlesV1.Work = new WorkExperience("Microsoft", "2018-2020");
            // charles.Display();
            // charlesV1.Display();


            // // Chapter 8 Factory Model VS Simple Factory Model
            // //Simple Factory
            // GoodMan undergraduate = OO_Design_Patterns.Factory.SimpleFactory.CreateGoodMan("undergraduate");
            // GoodMan volunteer = OO_Design_Patterns.Factory.SimpleFactory.CreateGoodMan("volunteer");

            // //Factory
            // IFactory volunteerFactory = new VolunteerFactory();
            // GoodMan volunteer2 = volunteerFactory.CreateGoodMan();
            // IFactory undergraduateFactory = new UndergraduateFactory();
            // GoodMan undergraduate2 = undergraduateFactory.CreateGoodMan();


            // //Chapter 7 Proxy
            // var mary = new SchoolGirl("Mary");

            // var charles = new Agent(mary);

            // charles.GiveChocolate();
            // charles.GiveDoll();
            // charles.GiveFlowers();

            // Chapter 6 Decorator
            // var charles = new Person("Charles");
            // var sneaker = new Sneaker();
            // var tShirt = new TShirt();
            // sneaker.Decorate(charles);
            // tShirt.Decorate(sneaker);
            // tShirt.Show();
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
