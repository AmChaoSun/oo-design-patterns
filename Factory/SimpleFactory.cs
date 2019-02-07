namespace OO_Design_Patterns.Factory
{
    public class SimpleFactory
    {
        public static GoodMan CreateGoodMan(string type)
        {
            GoodMan goodMan = null;
            switch (type)
            {
                case "undergraduate": goodMan = new Undergraduate(); break;
                case "volunteer": goodMan = new Volunteer(); break;
                default: goodMan = new Volunteer(); break;
            }
            return goodMan;
        }
    }
}