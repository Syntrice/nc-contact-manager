using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.States
{
    public class MenuState : State
    {
        public MenuState(Application application) : base(application)
        {
        }

        public override void Run()
        {
            Console.WriteLine("Choose action:");
            Console.WriteLine("1: Add contact, 2: Update contact, 3: Delete contact, 4: Quit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    break; // AddState
                case "2":
                    break; // UpdateState
                case "3": 
                    break; // DeleteState
                case "4":
                    _application.isRunning = false;
                    break;
                default:
                    break;
            }

        }
    }
}
