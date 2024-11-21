using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    public static class DataManager
    {
        public static string Filepath { get; private set; } = "./people.csv";

        public static List<Person> ReadListFromCSV()
        {
            var list = new List<Person>();

            foreach (string line in File.ReadLines(Filepath))
            {
                var stripped = line.Trim().Split(',');
                Person p = new Person(stripped[0], stripped[1], stripped[2], stripped[3]);
                list.Add(p);
            }
            return list;
        }

        public static void WriteToCSV(Person person)
        { 
            string line = $"{person.Name}, {person.Birthdate}, {person.Phone}, {person.Email}";

            if (File.Exists(Filepath))
            {
                using (StreamWriter sw = File.AppendText(Filepath))
                {
                    sw.WriteLine(line);
                }
            }
            else 
            {
                File.WriteAllText(Filepath, line + "\n");
            }   
        }
    }
}
