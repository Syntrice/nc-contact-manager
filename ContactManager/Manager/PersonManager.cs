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
            Person person = new Person(name, birthdate, phone, email, id);
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
            foreach (Person p in _contacts)
            {
                peopleInformation.Add($"Id: {p.Id}, Name: {p.Name}, Birthdate: {p.Birthdate}, Phone: {p.Phone}, Email: {p.Email}");
            }
            return peopleInformation;
        }

        public void SavePeople() // TODO: Perhaps make IDisposable and save in Dispose?
        {
            _fileManager.WritePeopleCSV(_contacts);
        }
    }
}