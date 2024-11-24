﻿namespace ContactManager.Data
{
    public class Person
    {
        public string Birthdate { get; }
        public string Email { get; }
        public string Name { get; }
        public string Phone { get; }

        public Person(string name, string birthdate, string phone, string email)
        {
            Name = name;
            Birthdate = birthdate;
            Phone = phone;
            Email = email;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Birthdate: {Birthdate}, Phone: {Phone}, Email: {Email}";
        }

        public static readonly DataValidator<Person> PersonValidator = new(new List<(Predicate<Person>, string)>
        {
            (p => p.Name.Length > 0, "Name cannot be empty"),
            (p => p.Birthdate.Length > 0, "Birthdate cannot be empty"),
            (p => p.Phone.Length > 0, "Phone cannot be empty"),
            (p => p.Email.Length > 0, "Email cannot be empty")
        }
        );
        
    }
}