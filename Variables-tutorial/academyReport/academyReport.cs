using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentReport
{
    class Program
    {
        static void Main(string[] args)
        {   
            // opening lines of text, first two lines are introductory and don't require input 
            Console.WriteLine("Academy of Learning Career College");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What is your name?"); //takes user input on the name
            string yourName = Console.ReadLine(); //creates a string for the users name & keeps program running
            Console.WriteLine("What course are you working on?"); //asks question for the current course
            string currentCourse = Console.ReadLine(); //creates a string for the users current course and keeps program running
            Console.WriteLine("What page number is it?"); //asks question as to what page number the user is on
            int pageNum = Convert.ToInt32(Console.ReadLine()); //assigns pageNum as an int and converts it to an int if someone entered a string and keeps program running
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"."); //asks a t/f question
            string reqHelp = Console.ReadLine(); //creates is as a string & keeps program running
            bool needHelp = bool.Parse(reqHelp); //creates a bool and parses the string into a boolean
            Console.WriteLine("Were there any positive experiences you'd like to share? Please be specific"); //question on positive experiences
            string posExp = Console.ReadLine(); //creates a string based on the input & keeps program running
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific"); //question on other feedback
            string feedBack = Console.ReadLine(); //creates a string for the feedback & keeps program running
            Console.WriteLine("How many hours did you study today?"); //asks how many hours was studied 
            int hoursStudided = Convert.ToInt32(Console.ReadLine()); //creates an int for the hours studied and converts the answer to an int incase a string was entered
            Console.WriteLine("Thank you for your answers. An Instructor will respond shortly, have a great day!"); //final declaration indicating no further questions
            Console.ReadLine();
        }
    }
}
