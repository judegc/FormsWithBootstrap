using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    public class Author
    {
        //constructor
        public Author(string firstName, string lastName, int age, string bio)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Bio = bio;
        }


        //properties (and fields)

        //private string _firstName; //field
        //public string FirstName //property
        //{
        //    get { return _firstName; }
        //    set { _firstName = value; }
        //}
        public string FirstName { get; private set; } //this property gives us the same behavior as the six lines above
        public string LastName { get; private set; }

        private int _age; //field
        public int Age //property (the gatekeeper to the field)
        {
            get { return _age; }
            private set //customized setter to protect against certain value assignments
            {
                if (value < 0) value = 0;
                _age = value;
            }
        }
        public string Bio { get; private set; }
    }
}
