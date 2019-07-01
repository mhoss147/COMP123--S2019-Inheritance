using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123__S2019_Inheritance
{
    public class DomesticStudent : Student
    {  
        //public properties
        public String DomesticAddress
        {
            get; private set; //read-only
        }

       

        //constructors----------------
        /// <summary>
        /// this is the constructor - takes 3 arguments - name(string), age(int) and studentid(string) 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="studentID"></param>
        public DomesticStudent(string name, int age, string studentID)
            :base( name,  age,  studentID)
          
        {
        }
     // public methods
     /// <summary>
     /// this methd set domestic address property
     /// </summary>
     /// <param name="address"></param>
      public void SetDomesticAddress(string address)
        {
            this.DomesticAddress = address;
        }
    }
}