using ContactManager.Data;

namespace ContactManager.Manager
{
    internal class FileManager
    {
        public string Path { get; }

        public FileManager(string path)
        {
            Path = path;
        }

        public List<Person> ReadPeopleCSV()
        {
            List<Person> people = new List<Person>();

            if (!File.Exists(Path))
            {
                return people;
            }

            int lineNumber = 0;
            foreach (string line in File.ReadLines(Path))
            {
                string[] parts = line.Split(',');

                string name = parts[0];
                string birthdate = parts[1];
                string phone = parts[2];
                string email = parts[3];

                Person person = new Person(name, birthdate, phone, email, lineNumber);
                ValidationResult validationResult = Person.PersonValidator.Validate(person);

                if (!validationResult.IsValid)
                {
                    throw new FormatException($"Error reading line {lineNumber}: {String.Join(", ", validationResult.Messages)}");
                }

                people.Add(person);
                lineNumber++;
            }

            return people;
        }

        public void WritePeopleCSV(List<Person> people)
        {
            using (StreamWriter writer = new StreamWriter(Path))
            {
                foreach (Person p in people)
                {
                    writer.WriteLine($"{p.Name},{p.Birthdate},{p.Phone},{p.Email}");
                }
            }
        }

    }
}
