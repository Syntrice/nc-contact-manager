using ContactManager.Data;

namespace ContactManager.Manager
{
    public class PersonManager
    {
        public List<Person> Contacts { get; private set; }

        public PersonManager()
        {
            Contacts = new List<Person>();
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
    }
}