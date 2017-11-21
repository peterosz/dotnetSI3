using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertTextFileToUTF7
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader(@"C:\Users\ithar\Documents\test\test.txt"))
            using (StreamWriter writer = new StreamWriter(@"C:\Users\ithar\Documents\test\test-utf7.txt", false, Encoding.UTF7))
            writer.WriteLine(reader.ReadToEnd());
        }
    }
}
