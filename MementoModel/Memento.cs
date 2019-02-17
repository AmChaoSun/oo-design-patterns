namespace OO_Design_Patterns.MementoModel
{
    public class Memento
    {
        public int PropertyA { get; set; }
        public string PropertyB { get; set; }

        public Memento(int propertyA, string propertyB)
        {
            PropertyA = propertyA;
            PropertyB = propertyB;
        }
    }
}