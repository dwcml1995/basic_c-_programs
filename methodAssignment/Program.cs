using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 mathOperation = new Class1(); //instantiated the class
            Console.WriteLine("Please input 2 whole numbers"); //provided user with instructions
            Console.WriteLine("Please input the first number"); //prompted user for the first number
            int userInput = Convert.ToInt32(Console.ReadLine()); // read the input and converted to an integer
            Console.WriteLine("Please input the second number, if you prefer, you can also just press enter to continue"); //prompted the user to make a decision, either enter a second number or press enter
            try 
            {
                int userInput1 = Convert.ToInt32(Console.ReadLine()); // read the input and converted to an integer
                int result = mathOperation.Operation(userInput, userInput1); //created the result as an integer, calls the class and performs the operation on both numbers the user enters
                Console.WriteLine(userInput + " * " + userInput1 + " = " + result); //prints the result of multiplying their input and assigns it to the result variable
            }
            catch
            {
                int results = mathOperation.Operation(userInput); //incase the user only inputs 1 number and proceeds, created results as a variable, calls the class and performs the operation on their input
                Console.WriteLine(userInput + " * Default = " + results); //prints the result of their input with the default number I assigned as an optional 
            }
            Console.ReadLine();
        }
    }
}
