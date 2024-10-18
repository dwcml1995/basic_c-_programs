using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employees_people
{
    public class employee : person, IQuittable //employee class that inherits props from person class
    {
        public int id { get; set; } //set the property for id

        public override void sayName() //implemented the sayname method in the class 
        {
            Console.WriteLine("Name: " + firstName + lastName);
        }
        public void Quit() //implemented the quit method 
        {
            Console.WriteLine($"{firstName} {lastName} has quit.");
        }
    }
}
