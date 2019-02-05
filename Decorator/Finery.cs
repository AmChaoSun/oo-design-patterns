namespace OO_Design_Patterns.Decorator
{
    public class Finery : Person
    {
        protected Person person;

        public void Decorate(Person person)
        {
            this.person = person;
        }

        public override void Show()
        {
            if (person != null)
            {
                person.Show();
            }
        }
    }
}