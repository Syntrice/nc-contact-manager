using ContactManager.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    public class Application
    {
        public State State { get; set; }
        public bool isRunning { get; set; } = true;

        public PersonManager PersonManager { get; }

        public Application()
        {
            PersonManager = new PersonManager();
            State = new MenuState(this);
        }

        public void Run()
        {
            while(isRunning)
            {
                State.Run();
            }
        }

    }
}
