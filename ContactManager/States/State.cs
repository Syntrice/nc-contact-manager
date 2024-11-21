namespace ContactManager.States
{
    public abstract class State
    {
        protected Application _application;

        public State(Application application)
        {
            _application = application;
        }

        public abstract void Run();
    }
}