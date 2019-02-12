namespace OO_Design_Patterns.Builder
{
    public class ConcreteBuilderB : Builder
    {
        private Product product = new Product();

        public override void BuildPartA()
        {
            product.Add("part X");
        }

        public override void BuildPartB()
        {
            product.Add("part Y");
        }

        public override Product GetProduct()
        {
            return product;
        }
    }
}