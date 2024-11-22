using ContactManager.States;

namespace ContactManager
{
    public class Application
    {
        private bool _isRunning;

        public PersonManager PersonManager { get; }
        public State State { get; set; }

        public Application()
        {
            PersonManager = new PersonManager();
            State = new MenuState(this);
        }

        public void Run()
        {
            _isRunning = true;
            while (_isRunning)
            {
                State.Run();
            }
        }

        public void Stop()
        {
            _isRunning = false;
        }
    }
}