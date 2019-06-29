using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123__S2019_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n");
            Person person = new Person("Mohammad", 20 );
            person.Talks();
            Console.WriteLine("\n");

        }
    }
}
