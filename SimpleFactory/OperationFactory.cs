namespace OO_Design_Patterns.SimpleFactory
{
    //only have +, -, *, /
    public class OperationFactory
    {
        public static GenericOperation CreateOperation(string oprator)
        {
            GenericOperation operation = null;
            switch (oprator)
            {
                case "+":
                    operation = new AddOperation();
                    break;
                case "-":
                    operation = new SubOperation();
                    break;
                case "*":
                    operation = new MulOperation();
                    break;
                case "/":
                    operation = new DivOperation();
                    break;
                default:
                    throw new System.ArgumentException(string.Format("{0} operation is not defined.", oprator));
                    // break;
            }
            return operation;
        }
    }
}