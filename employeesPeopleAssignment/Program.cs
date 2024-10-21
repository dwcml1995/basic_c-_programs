using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employees_people
{
    public class Program
    {
        static void Main(string[] args)
        {
            //instantiate the first employee object
            Employee employee1 = new Employee(); 
            employee1.FirstName = "Sample"; 
            employee1.LastName = "Student"; 
            employee1.Id = 1;

            //instantiate the second employee object
            Employee employee2 = new Employee(); 
            employee2.FirstName = "Another"; 
            employee2.LastName = "Employee"; 
            employee2.Id = 2; 

            //call the SayName method on both employee objects
            employee1.SayName();
            employee2.SayName();

            //compare the two employee objects using overloaded == operator
            if (employee1 == employee2)
            {
                Console.WriteLine("The two employees are equal.");
            }
            else
            {
                Console.WriteLine("The two employees are not equal.");
            }

            
            IQuittable quitter = employee1; //used polymorphism
            quitter.Quit();  //called the quit method

            //keep the console open
            Console.ReadLine();
        }
    }
}
