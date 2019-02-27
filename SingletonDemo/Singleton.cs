namespace OO_Design_Patterns.SingletonDemo
{
    //double lock
    public class Singleton
    {
        private static Singleton instance;
        private static readonly object syncRoot = new object();
        private Singleton() { }

        public static Singleton Instance()
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                }
            }
            return instance;
        }
    }

    // //another way to make singleton
    // public sealed class Singleton
    // {
    //     private static readonly Singleton instance = new Singleton();

    //     private Singleton() { }

    //     public static Singleton Instance()
    //     {
    //         return instance;
    //     }
    // }

}