using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace arrayAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] langArray = {"JavaScript", "Python", "C", "C+", "C++", "C#", "SQL", "Java", "Ruby"}; //creates an array of strings
            Console.WriteLine("Please select a number from 0-8!"); //prompts the user to input an integer between 0-8
            int userChoice = Convert.ToInt32(Console.ReadLine()); //reads the user input and converts to an integer
            bool isValid = false; //boolean if the choice is valid or not 

            while (!isValid) //while loop saying the input is not valid 
            {
                try //try statement to see whether the user input a valid integer
                {
                    Console.WriteLine("Your programming language is " + langArray[userChoice]); //console will display the users programming language, based on if they input a correct integer and concats it to the array, showing the users choice
                    isValid = true; //they did input a valid integer, so isValid will be assigned as true!
                }
                catch  //catch block incase the input is not valid
                {
                    Console.WriteLine("Sorry, please select a number between 0-8 "); //prompts the user to then select a valid integer if they hadn't the first go around
                    userChoice = Convert.ToInt32(Console.ReadLine()); //reads the users input, converts to an integer and while loop iterates again
                }
                int[] numArray = { 8, 13, 19, 20, 25, 43, 70, 74, 77, 92 }; //creates an array of integers
                Console.WriteLine("Please select a number between 0-9!"); //prompts the user to select an integer between 0-9
                int usersChoice = Convert.ToInt32(Console.ReadLine()); //reads the user input and converts to an integer
                bool validChoice = false;//boolean if the choice is valid or not  

                while (!validChoice) //while loop saying the input is not valid 
                {
                    try //try statement to see whether the user input a valid integer
                    {
                        Console.WriteLine("The number of the player on the Washington Capitals in the Stanley Cup run is " + numArray[usersChoice]); //console will display the users number, based on if they input a correct integer and concats it to the array, showing the users choice
                        validChoice = true; //if they did select a valid integer, the boolean variable would be assigned as true
                    }
                    catch //catch block incase the input was not valid
                    {
                        Console.WriteLine("Sorry, please select a number between 0-9"); //prompts the user to select a valid integer again
                        usersChoice = Convert.ToInt32(Console.ReadLine()); //reads the user input and while loop would iterate again to return back to the try block to display the choice on the console
                    }
                    List<string> strList = new List<string>() //creates a list as a string 
                    {
                        "Washington Capitals",
                        "Edmonton Oilers",
                        "Toronto Maple Leafs",
                        "Winnipeg Jets",
                        "Florida Panthers",
                        "Colorado Avalanche",
                        "Columbus Blue Jackets",
                        "Dallas Stars",
                        "Buffalo Sabres",
                        "Utah Hockey Club"
                    };
                    Console.WriteLine("Please select a number from 0-9"); //prompts the user to select an integer between 0-9
                    int userSelect = Convert.ToInt32(Console.ReadLine()); //reads the users input and converts to an integer
                    bool inputChoice = false; //boolean value to show if the choice is valid or not
                    
                    while (!inputChoice) //while loop, if the users input is not false

                    try  //try block to iterate through
                    {
                        Console.WriteLine("The team you selected is " + strList[userSelect]); //console will display the string and concat with the string list with the value of the users input
                        inputChoice = true; //validates the input choice is true
                    }
                    catch //catch block incase the input was not valid
                    {
                        Console.WriteLine("Sorry, please select a number between 0-9"); //prompts the user to again select a valid integer
                        userSelect = Convert.ToInt32(Console.ReadLine()); //converts the users input to an integer, iterates through the loop again to get back to the try block to display their selection
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
