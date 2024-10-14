using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace math1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lastString = { "Charlottetown", "Halifax", "Toronto", "Vancouver", "St. John's", "Whitehorse", "Quebec City", "Halifax" }; //creates a list of strings, with 1 duplicate

            HashSet<string> uniqueCity = new HashSet<string>(); //created a hashset so I can track unique city names in the string

            foreach (string str in lastString) //iterating through each item on the list
            {
                if (uniqueCity.Contains(str)) //here it checks if the city is in the hashset yet
                {
                    Console.WriteLine($"{str} is a duplicate city"); //console will print the the str if it is a duplicate city
                }
                else 
                {
                    Console.WriteLine($"{str} is a unique city"); //console takes the str and prints it's a unique city
                    uniqueCity.Add(str); //unique city variable adds the str to the list 
                }
            }

            string[] myString = { "Baylie", "Leon", "Tiggy", "Zen", "Minny", "Itachi", "Ash" }; //creating a string of pet names
            Console.WriteLine("Please select a number between 0-6 to see which of my animals you selected!"); //prompting a user to input a digit

            int userInput = Convert.ToInt32(Console.ReadLine()); //assigning a string for user input 

            for (int i = 0; i < myString.Length; i++) //for loop to iterate over the string length and add 1
            {
                myString[i] += " " + userInput; //concat the i indedx with a blank space and the users input
            }

            for (int i = 0; i < myString.Length; i++) //for loop to iterate over the string length and add 1
            {
                Console.WriteLine("The animal you selected is " + myString[i]); //concats the text with myString at the index of i which is the users selection
            }


            string[] fastFoodChains = { "Wendys", "A&W", "Dairy Queen", "Taco Bell", "Thai Express", "White Castle", "Five Guys", "Little Caesars" }; //creates a string of fast food restaurants
            Console.WriteLine("Please input the name of a fast food chain to see if it's on our list"); //prompts the user to input a selection

            string userSelection = Console.ReadLine(); //takes the users selection as a string and reads the line

            bool ifFound = false; //created a boolean to start with a false to enter the loop to see whether their input was t/f

            for (int i = 0; i < fastFoodChains.Length; i++) //iterates through the for loop with i beginning at 0 and adding 1 after each iteration until complete
            {
                if (fastFoodChains[i].ToLower() == userSelection.ToLower()) // if the users choice on the fast food chains is on the list, do the following
                {
                    Console.WriteLine($"The fast food chain '{userSelection}' is located at index {i}."); //notifies the user what index their selection is at 
                    ifFound = true; //assigns the boolean true as the values matched up
                    break; //ends loop
                }
                if (!ifFound) //if not found, 
                {
                    Console.WriteLine($"The fast food chain '{userSelection}' was not found"); //we notify them their selection was not found
                }
            }

            string[] identicalStrings = { "Dominos", "Pizza Delight", "Pizza Hut", "Greco", "Boston Pizza", "Pizza Hut" }; //list of strings that has 2 identical strings on the list
            Console.WriteLine("Please input the name of a pizza chain to see if it is on our list"); //prompts the user to input a pizza chains name

            string usersPizza = Console.ReadLine(); //assigns the users selection as a string and console reads their input

            bool found = false; //created a boolean incase the input is false, so we can loop through the list

            for (int i = 0; i < identicalStrings.Length; i++) //for loop to iterate through the list, so if the string of restaurants is not complete, add one after each iteration until complete
            {
                if (identicalStrings[i].ToLower() == usersPizza.ToLower()) //if the item is located on our list of strings and that equals the users selection, we will go through the loop to check 
                {
                    Console.WriteLine($"The pizza place '{usersPizza}' is located at index '{i}'."); //the console will print the name of the users selection and the index it can be found at
                    found = true; //assigns our boolean found to true
                }
            }
            if (!found) //if their input is not found, we will notify them
            {
                Console.WriteLine($"The pizza place '{usersPizza}' was not found."); //notify user the restauarant they entered was not found 
            }    
            


            Console.WriteLine("Please select a number to go up to"); //prompts the user to select an integer to iterate up to 
            int usersInput = Convert.ToInt32(Console.ReadLine()); //assigns and converts their input to an integer and the console reads the input

            int z = 0; //setting z as an integer to begin @ 0

            while (z < usersInput) //while loop if z is less than the users input
            {
                Console.WriteLine("The value of your input is " + z); //console prints the text string and concats with z
                z++; //z adds one through each iteration until arriving at the users input
            }

            Console.WriteLine("Please select a number to go up to"); //prompts the user to select an integer to iterate up to 
            int userChoice = Convert.ToInt32(Console.ReadLine());  //assigns and converts their input to an integer and the console reads the input

            int v = 0; //setting v as an integer to begin @ 0

            while (v <= userChoice)  //while loop if v is less than the users input
            {
                Console.WriteLine("Your input was greater than or equal to: " + v);  //console prints the text string and concats with v
                v++;  //v adds one through each iteration until arriving at the users input
            }


            while (true) //starts infinite loops / fixed it
            {
                Console.WriteLine("You're stuck in the infinite loop! Try to quit by pressing f :)"); //prints this to the console repeatedly 

                if (Console.KeyAvailable) //checks if the user wishes to exit
                {
                    var key = Console.ReadKey(true).KeyChar; //obtain the key stroke
                    if (key == 'f')
                    {
                        break; //exits the loop if the key stroke is f
                    }
                }
            }
            Console.WriteLine("Congratulations, you have exited the infinite loop! Press enter to leave for good :D");
            Console.ReadLine();
        }
    }
}