namespace OO_Design_Patterns.SimpleFactory
{
    public abstract class GenericOperation
    {
        public double NumA { get; set; }
        public double NumB { get; set; }

        public virtual double GetResult()
        {
            double result = 0;
            return result;
        }

    }
}