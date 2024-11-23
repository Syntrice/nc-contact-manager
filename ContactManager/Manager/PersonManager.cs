using ContactManager.Data;

namespace ContactManager.Manager
{
    public class PersonManager
    {
        private FileManager _fileManager;
        private List<Person> _contacts;

        public PersonManager()
        {
            _fileManager = new FileManager("contacts.csv"); // TODO: Use a constant for the file 
            _contacts = _fileManager.ReadPeopleCSV();
        }

        public ValidationResult AddPerson(string name, string birthdate, string phone, string email)
        {
            int id = _contacts.Count;
            Person person = new Person(name, birthdate, phone, email);
            ValidationResult validationResult = Person.PersonValidator.Validate(person);

            if (validationResult.IsValid)
            {
                _contacts.Add(person);
            }

            return validationResult;
        }

        public List<String> GetPeopleInformationList()
        {

            List<String> peopleInformation = new List<String>();

            for (int i = 0; i < _contacts.Count; i++)
            {
                Person p = _contacts[i];
                peopleInformation.Add($"Id: {i}, {p.ToString()}");
            }

            return peopleInformation;
        }

        public void SavePeople() // TODO: Perhaps make IDisposable and save in Dispose?
        {
            _fileManager.WritePeopleCSV(_contacts);
        }

        public (ValidationResult Validation, String? Result) GetPersonInformation(int id)
        {
            if (id < 0 || id >= _contacts.Count)
            {
                return (new ValidationResult(false, ["Invalid Person ID"]), null);
            }
            Person p = _contacts[id];

            return (ValidationResult.Success(), $"Id: {id}, {p.ToString()}");
        }

        public ValidationResult DeletePerson(int id)
        {
            if (id < 0 || id >= _contacts.Count)
            {
                return new ValidationResult(false, ["Invalid Person ID"]);
            }

            _contacts.RemoveAt(id);
            return ValidationResult.Success();
        }
    }
}