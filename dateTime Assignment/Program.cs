using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dateTime_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now); //prints the current date and time to console
            Console.WriteLine("Please enter a whole number between 0-24"); //prompts user to input an integer
            int userInput = Convert.ToInt32(Console.ReadLine()); //reads user input and converts to int
            Console.WriteLine("In {0} hours it will be: {1} ",  userInput, DateTime.Now.AddHours(userInput)); //prints what date and time it will be based on the current time and users input
            Console.ReadLine(); //keeps console open
        }
    }
}
