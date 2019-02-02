namespace OO_Design_Patterns.SimpleFactory
{
    public class AddOperation : GenericOperation
    {
        public override double GetResult()
        {
            double result = NumA + NumB;
            return result;
        }
    }
}