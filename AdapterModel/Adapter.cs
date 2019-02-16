namespace OO_Design_Patterns.AdapterModel
{
    public class Adapter : ITarget
    {
        private Adaptee adaptee = new Adaptee();

        public void Request()
        {
            adaptee.SpecialRequest();
        }
    }
}