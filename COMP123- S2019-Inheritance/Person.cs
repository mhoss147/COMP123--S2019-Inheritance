using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123__S2019_Inheritance
{/// <summary>
/// this is the person class
/// </summary>
    class Person
    {
        //private instance variables
        private string _name;
        private int _age;
        // public properties
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        public int Age
        {
            get
            {
                return this._age;
            }
            set
            {
                this._age = value;
            }
        }
        //constructors
        /// <summary>
        /// this is the constructor for the Person class
        /// it takes 2 arguments - name (string) and age (int)
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        //public methods
        /// <summary>
        /// this method enables Person object to talk
        /// </summary>
        public void Talks()
        {
            Console.WriteLine(this.Name + " is talking");
        }

    }
}
