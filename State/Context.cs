namespace OO_Design_Patterns.State
{
    public class Context
    {
        private State state;
        public Context(State state)
        {
            this.state = state;
        }

        public void Handle()
        {
            state.Handle(this);
        }
    }
}