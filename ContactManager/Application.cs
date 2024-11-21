using ContactManager.States;

namespace ContactManager
{
    public class Application
    {
        public bool isRunning { get; set; } = true;
        public PersonManager PersonManager { get; }
        public State State { get; set; }

        public Application()
        {
            PersonManager = new PersonManager();
            State = new MenuState(this);
        }

        public void Run()
        {
            while (isRunning)
            {
                State.Run();
            }
        }
    }
}