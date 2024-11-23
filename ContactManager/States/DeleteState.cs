using System.ComponentModel.DataAnnotations;

namespace ContactManager.States
{
    public class DeleteState : State
    {
        public DeleteState(Application application) : base(application)
        {
        }

        public override void Run()
        {
            Console.WriteLine("Enter ID of contact to delete:");
            int id;

            if (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("ID must be an integer value");
                _application.State = new MenuState(_application);
                return;
            }

            var personInformation = _application.PersonManager.GetPersonInformation(id);

            if (!personInformation.Validation.IsValid)
            {
                Console.WriteLine("Error deleting contact");
                Console.WriteLine(String.Join("\n", personInformation.Validation.Messages));
                return;
            }
            else
            {
                Console.WriteLine("Deleting the following contact:");
                Console.WriteLine(personInformation.Result);
                _application.PersonManager.DeletePerson(id);
                // validate here
                _application.State = new MenuState(_application);
            }
        }
    }
}