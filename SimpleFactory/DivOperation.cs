namespace OO_Design_Patterns.SimpleFactory
{
    public class DivOperation : GenericOperation
    {
        public override double GetResult()
        {
            if (NumB == 0)
            {
                throw new System.ArgumentException("Cannot be divided by zero");
            }
            double result = NumA / NumB;
            return result;
        }
    }
}