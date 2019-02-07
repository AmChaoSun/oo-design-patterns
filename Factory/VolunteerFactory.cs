namespace OO_Design_Patterns.Factory
{
    public class VolunteerFactory : IFactory
    {
        public GoodMan CreateGoodMan()
        {
            return new Volunteer();
        }
    }
}