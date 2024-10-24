using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryCatchAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter your age, in numerics"); //prompts user to enter their age
                int userInput = Convert.ToInt32(Console.ReadLine()); //reads line and converts input to an integer
                if (userInput <= 0) //if the user input is equal to or less than 0
                {
                    throw new ArgumentOutOfRangeException("Your age must be a positive number & it must be greater than 0."); //throw an exception instructing them what to do
                }
                int currentYear = DateTime.Now.Year; //assigned the current year as an integer 
                int usersBirthday = currentYear - userInput; //created a variable to take the current year subtracted from the users input
                Console.WriteLine("You were born in " + usersBirthday); //displays message showing the year they were born
            }
            catch (FormatException) //format exceptions
            {
                Console.WriteLine("Please enter a valid numeric digit for your age.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("An error occured. Please try again.");
            }
            Console.ReadLine();
        }
    }
}
