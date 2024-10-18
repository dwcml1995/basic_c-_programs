using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace employees_people
{
    public class Program
    {
        static void Main(string[] args)
        {
            employee employee = new employee(); //instantiated the employee class 
            employee.firstName = "Sample"; //initiliazed the first name
            employee.lastName = "Student"; //init last name
            employee.sayName(); //called superclass on the employee object
            Console.ReadLine(); //keeps console open 
            IQuittable Quit = employee; //used polymorphism
            Quit.Quit(); //called the quit method
        }
    }
}
