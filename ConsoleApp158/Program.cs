using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp158
{
    class Program
    {
        static void Main(string[] args)
        {
            var string1 = "cheers!";
            var string2 = "GOOD BYE";
            var string3 = "    spaces     ";


            Console.WriteLine($"string1=\"{string1}\"\n" + $"string2=\"{string2}\"\n" + $"string3=\"{string3}\"");

            Console.WriteLine($"\nReplacing \"e\" with \"E\" in string1:" + $"\"{string1.Replace('e', 'E')}\"");

            Console.WriteLine($"\nstring1.ToUpper=\"{string1.ToUpper()}\"" + $"\nstring2.ToLower=\"{string2.ToLower()}\"");


            Console.WriteLine($"\nstring3 after Trim=\"{string3.Trim()}\"");


            Console.WriteLine($"string1=\"{string1}\"");

            Console.ReadLine();







        }
    }
}
