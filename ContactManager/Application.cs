using ContactManager.Manager;
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
            Console.WriteLine("-- Contact Manager --");
            _isRunning = true;
            while (_isRunning)
            {
                Console.WriteLine();
                State.Run();
            }
        }

        public void Stop()
        {
            PersonManager.SavePeople();
            _isRunning = false;
        }
    }
}