﻿using System;
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

            Console.WriteLine("\n");
            Student student = new Student("Mubarrat", 18, "300234533");
            student.Studies();
            student.Talks();

            Console.WriteLine("\n");



        }
    }
}
