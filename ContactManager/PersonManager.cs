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
            // TODO: complete validation and return validation result


            Person person = new Person(name, birthdate, phone, email);

            //UpdateName(person.Id, name);
            //UpdateBirthdate(person.Id, birthdate);
            //UpdatePhone(person.Id, phone);
            //UpdateEmail(person.Id, email);

            Contacts.Add(person);
            DataManager.WriteToCSV(person);
        }

        private Person? getPersonById(int id)
        {
            return Contacts.Find(person => person.Id == id);
        }

        public ValidationResult UpdateName(int id, string newName)
        {
            Person? person = getPersonById(id);

            if (person == null)
            {
                return new ValidationResult(false, $"No such person with id {id}");
            }

            person.Name = newName;

            return new ValidationResult(true);
        }

        public ValidationResult UpdateBirthdate(int id, string newBirthdate)
        {
            Person? person = getPersonById(id);

            if (person == null)
            {
                return new ValidationResult(false, $"No such person with id {id}");
            }

            person.Birthdate = newBirthdate;

            return new ValidationResult(true);
        }

        public ValidationResult UpdatePhone(int id, string newPhone)
        {
            Person? person = getPersonById(id);

            if (person == null)
            {
                return new ValidationResult(false, $"No such person with id {id}");
            }

            person.Phone = newPhone;

            return new ValidationResult(true);
        }

        public ValidationResult UpdateEmail(int id, string newEmail)
        {
            Person? person = getPersonById(id);

            if (person == null)
            {
                return new ValidationResult(false, $"No such person with id {id}");
            }

            person.Email = newEmail;

            return new ValidationResult(true);
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
