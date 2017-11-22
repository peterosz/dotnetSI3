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
    [Serializable]
    public class Person
    {
        public enum Genders { Male, Female };
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public Genders Gender { get; set; }
        public int Age;
        static string fileName = "SerializedPeople.binary";

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

        public void Serialize()
        {
            using (FileStream newTextFile = File.Create(fileName))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                try
                {                 
                    formatter.Serialize(newTextFile, this);
                }
                catch (SerializationException ex)
                {
                    Console.WriteLine("Failed to serialize. Reason: " + ex.Message);
                }
            }
        }

        public void Deserialize()
        {
            Person person = new Person(); 
            List<object> deserializedList = new List<object>();
            using (FileStream openFile = new FileStream(fileName, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                try
                {
                    person = (Person)formatter.Deserialize(openFile);
                }
                catch (SerializationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine(person.ToString());
        }
    }
}
