namespace ContactManager
{
    public class PersonManager
    {
        public List<Person> Contacts { get; private set; }

        public PersonManager()
        {
            Contacts = DataManager.ReadListFromCSV();
        }

        public void AddPerson(string name, string birthdate, string phone, string email)
        {
            Person person = new Person(name, birthdate, phone, email);
            Contacts.Add(person);
            DataManager.WriteToCSV(person);
        }

        public void ListPeople()
        {
            foreach(Person p in Contacts)
            {
                Console.WriteLine(p.Name);
            }
        }
    }
}
