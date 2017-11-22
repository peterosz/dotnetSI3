using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerializePeople
{
    public class Person
    {
        public enum Genders { Male, Female };

        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public Genders Gender { get; set; }
        public int Age;
        static int counter;
        static Dictionary<int,List<string>> people = new Dictionary<int, List<string>>();

        public Person() { }

        public Person(string Name, DateTime BirthDate, Genders Gender)
        {
            counter++;
            this.Name = Name;
            this.BirthDate = BirthDate;
            this.Gender = Gender;
            Age = DateTime.Now.Year - BirthDate.Year;
            people.Add(counter, new List<string> { Name, Age.ToString(), BirthDate.ToString(), Gender.ToString()});
        }

        public override string ToString()
        {
            return "\n Name: " + Name +
                   "\n Age: " + Age +
                   "\n Date of Birth: " + BirthDate.ToString("yyyy/MM/dd") +
                   "\n Gender: " + Gender;
        }

        public static void Serialize()
        {
            string fileName = "SerializedPeople.txt";
            FileInfo oldFile = new FileInfo("..\\" +fileName);
            try
            {
                oldFile.Delete();
            }
            catch (FileNotFoundException exc)
            {
                Console.WriteLine(exc.Message);
            }
             
            using (FileStream newTextFile = File.Create(fileName))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                try
                {
                    formatter.Serialize(newTextFile, people);
                }
                catch (SerializationException ex)
                {
                    Console.WriteLine("Failed to serialize. Reason: " + ex.Message);
                }
            }
        }
    }
}
