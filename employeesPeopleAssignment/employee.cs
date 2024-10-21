using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employees_people
{
    public class employee : person, IQuittable //employee class that inherits props from person class
    {
        public int id { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override void sayName() //implemented the sayname method in the class 
        {
            Console.WriteLine("Name: " + FirstName + LastName);
        }
        public void Quit() //implemented the quit method 
        {
            Console.WriteLine($"{firstName} {lastName} has quit.");
        }
        public static bool operator ==(employee employee1, employee employee2) //overloading == operator to compare employees by id 
        {
            if (ReferenceEquals(employee1, employee2)) //if both are null or the same reference, it will return true 
                return true;
            if (employee1 is null || employee2 is null) //if one is null, returns false 
                return false;
            return employee1.id == employee2.id; //compares the properties of each employee 
        }
        public static bool operator !=(employee employee1, employee employee2) //overloading != to be the opposite of teh == operator 
        {
            return !(employee1 == employee2); 
        }
    }
}
