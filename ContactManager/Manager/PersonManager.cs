using ContactManager.Data;

namespace ContactManager.Manager
{
    public class PersonManager
    {
        private FileManager _fileManager;
        public List<Person> Contacts { get; private set; }
        public PersonManager()
        {
            _fileManager = new FileManager("contacts.csv"); // TODO: Use a constant for the file 
            Contacts = _fileManager.ReadPeopleCSV();
        }

        public void AddPerson(string name, string birthdate, string phone, string email)
        {
            Person person = new Person(name, birthdate, phone, email);
            Contacts.Add(person);
        }

        public void ListPeople()
        {
            foreach (Person p in Contacts)
            {
                Console.WriteLine($"Name: {p.Name}, Birthdate: {p.Birthdate}, Phone: {p.Phone}, Email: {p.Email}");
            }
        }

        public void SavePeople() // TODO: Perhaps make IDisposable and save in Dispose?
        {
            _fileManager.WritePeopleCSV(Contacts);
        }
    }
}