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
            Console.WriteLine("1: Add contact, 2: Update contact, 3: Delete contact, 4: List contacts, 5: Quit");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1": // Add contact
                    _application.State = new AddState(_application);
                    break; 
                case "2": // Update contact
                    break; 
                case "3": // Delete contact
                    break; 
                case "4": // List contacts
                    _application.PersonManager.ListPeople();
                    break;
                case "5": // Quit application
                    _application.Stop();
                    break;
                default:
                    break;
            }
        }
    }
}