using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123__S2019_Inheritance
{/// <summary>
/// this is the student class
/// </summary>
   public  class Student : Person
    {
        // private instance variables (Fields)
        private string _studentID;
        
        // public properties
        public string StudentID
        {
            get
            {
                return this._studentID;
            }
            set
            {
                this._studentID = value;
            }
        }
        //constructors
        /// <summary>
        /// this is the constructor for student class
        /// it takes the arguments  - name (string), age (int) and studentID (string)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="studentID"></param>
        public Student(string name, int age, string studentID)
            : base(name, age)
        {
            this.StudentID = studentID;
        }

        //public method
        /// <summary>
        /// this is the studies method enables student to study.
        /// </summary>
        public void Studies()
        {
            Console.WriteLine(this.Name + " is studying");
        }
    }
}
