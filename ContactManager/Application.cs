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
        public void Run()
        {
            State = new MenuState(this);
            while(isRunning)
            {
                State.Run();
            }
        }

    }
}
