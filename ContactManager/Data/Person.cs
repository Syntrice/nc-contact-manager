﻿namespace ContactManager.Data
{
    public class Person
    {
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
        }

        public static readonly DataValidator<Person> PersonValidator = new();

        static Person()
        {
            PersonValidator.AddRule(p => p.Name.Length > 0, "Name cannot be empty");
            PersonValidator.AddRule(p => p.Birthdate.Length > 0, "Birthdate cannot be empty");
            PersonValidator.AddRule(p => p.Phone.Length > 0, "Phone cannot be empty");
            PersonValidator.AddRule(p => p.Email.Length > 0, "Email cannot be empty");
        }
    }
}