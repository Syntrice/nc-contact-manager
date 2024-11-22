namespace ContactManager.Data
{
    public class Person
    {
        public static int IdCounter = 0;
        public string Birthdate { get; }
        public string Email { get; }
        public int Id { get; }
        public string Name { get; }
        public string Phone { get; }

        public Person(string name, string birthdate, string phone, string email)
        {
            Name = name;
            Birthdate = birthdate;
            Phone = phone;
            Email = email;
            Id = IdCounter++;
        }
    }
}