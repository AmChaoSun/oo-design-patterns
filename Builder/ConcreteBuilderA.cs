namespace OO_Design_Patterns.Builder
{
    public class ConcreteBuilderA : Builder
    {
        private Product product = new Product();

        public override void BuildPartA()
        {
            product.Add("part A");
        }

        public override void BuildPartB()
        {
            product.Add("part B");
        }

        public override Product GetProduct()
        {
            return product;
        }
    }
}