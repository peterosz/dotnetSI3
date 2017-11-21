using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace SerializePeople
{
    public class Person
    {
        public enum Genders { Male, Female };

        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public Genders Gender { get; set; }
        public int Age;

        public Person() { }

        public Person(string Name, DateTime BirthDate, Genders Gender)
        {
            this.Name = Name;
            this.BirthDate = BirthDate;
            this.Gender = Gender;
            Age = DateTime.Now.Year - BirthDate.Year;
        }

        public override string ToString()
        {
            return "\n Name: " + Name +
                   "\n Age: " + Age +
                   "\n Date of Birth: " + BirthDate.ToString("yyyy/MM/dd") +
                   "\n Gender: " + Gender;
        }
    }
}
