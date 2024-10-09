using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace booleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Insurance application"); //first message in application
            Console.WriteLine("What is your age?"); //takes user input for their age
            int age = Convert.ToInt32(Console.ReadLine()); //converts age to an integer
            Console.WriteLine("Have you ever had a dui?"); //prompts user to answer if they've had a dui
            string answer = Console.ReadLine().toLower(); //assigns answer as a string and reads it 
            bool hasDui = answer == "yes"; //boolean variable asking if the answer is equal to yes
            Console.WriteLine("How many speeding tickets do you have?"); //prompts user to enter if they've had a speeding ticket
            int tickets = Convert.ToInt32(Console.ReadLine()); //tickets is assigned an integer and read 
            Console.WriteLine("Are you qualified for insurance?"); //shows if user is qualified for insurance based on below
            bool qualified = (age > 15) && !hasDui && (tickets <= 3); //qualified is a boolean and asks if the age is over 15, does not have a dui and 3 or less tickets
            Console.WriteLine(qualified); //prints qualifed if the above criteria is met
            Console.ReadLine(); //keeps program open till user hits enter
        }
    }
}