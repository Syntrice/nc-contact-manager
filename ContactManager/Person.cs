using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    public class Person
    {
        public static int IdCounter = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Birthdate { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

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
