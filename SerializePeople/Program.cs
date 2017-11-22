using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializePeople
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Peti = new Person("Peti", new DateTime(1986,06,30), Person.Genders.Male);
            Person RandomGuy = new Person("RandomGuy", new DateTime(1911, 01, 21), Person.Genders.Male);
            Console.WriteLine(Peti);
            Person.Serialize();
            Console.ReadKey();
        }
    }
}
