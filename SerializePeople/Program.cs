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
            Console.WriteLine(Peti);
            Console.ReadKey();
        }
    }
}
