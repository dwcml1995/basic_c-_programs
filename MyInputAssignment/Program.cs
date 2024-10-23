using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a valid whole number"); //prompts the user to enter a number
            int userInput = Convert.ToInt32(Console.ReadLine()); //reads their input and converts to an integer
            string filePath = @"C:\Users\Donavon\Logs\userInput.txt"; //files path for where im going to log it
            File.WriteAllText(filePath, Convert.ToString(userInput)); //takes the file path, and converts the users input to a string
            Console.WriteLine("The number you entered is " + File.ReadAllText(filePath)); //logs the number the user entered concatenating with where the txt file is stored
            Console.ReadLine(); //keeps console opened 
        }
    }
}
