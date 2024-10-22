using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambdaExpressions
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<employee> employees = new List<employee>(); //instantiated employee class as a list & created 10 employees
            new employee() { ID = 1, FirstName = "Billy", LastName = "Bob" };
            new employee() { ID = 2, FirstName = "Joe", LastName = "Schmo" };
            new employee() { ID = 3, FirstName = "Itachi", LastName = "Uchiha" };
            new employee() { ID = 4, FirstName = "Joe", LastName = "Beninati" };
            new employee() { ID = 5, FirstName = "Jarad", LastName = "Higgins" };
            new employee() { ID = 6, FirstName = "Symere", LastName = "Woods" };
            new employee() { ID = 7, FirstName = "Joey", LastName = "Kangaroo" };
            new employee() { ID = 8, FirstName = "Donavon", LastName = "William" };
            new employee() { ID = 9, FirstName = "Joe", LastName = "Throw" };
            new employee() { ID = 10, FirstName = "Last", LastName = "One" };
           
            List<employee> joes = new List<employee>(); //created a list for employees who are named job
            foreach (employee employee in employees) //using a foreach loop to achieve this
            {
                if (employee.FirstName == "Joe")
                {
                    joes.Add(employee); //if the employee is named joe, they are added to the list
                }
            }
            List<employee> joe = employees.Where(x => x.FirstName == "Joe").ToList(); //lambda to achieve the same thing 
            List<employee> IdOver5 = employees.Where(x => x.ID >= 5).ToList(); //lambda to find employees who ID is equal to or greater than 5 
            Console.ReadLine(); //keeps console open
        }
    }
}