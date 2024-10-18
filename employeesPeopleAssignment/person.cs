using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employees_people
{
    public abstract class person //made the class abstract
    {
        public string firstName { get; set; } //property of first name
        public string lastName { get; set; } //property of last name
        public abstract void sayName(); //void method that prints the users name to the console
    }
}
