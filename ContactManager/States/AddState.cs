namespace ContactManager.States
{
    public class AddState : State
    {
        public AddState(Application application) : base(application)
        {
        }

        public override void Run()
        {
            Console.WriteLine("New contact:");

            Console.Write("Please enter name:");
            string name = Console.ReadLine();

            Console.Write("Please enter birthdate:");
            string birthdate = Console.ReadLine();

            Console.Write("Please enter phone:");
            string phone = Console.ReadLine();

            Console.Write("Please enter email:");
            string email = Console.ReadLine();

            _application.PersonManager.AddPerson(name, birthdate, phone, email);
            Console.WriteLine("Contact Saved!");

            _application.State = new MenuState(_application);
        }
    }
}