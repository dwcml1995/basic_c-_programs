using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace branchingAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below"); //message to welcome the user to the service
            Console.WriteLine("Please enter the weight of the package"); //prompts the user to input the package weight
            int packWeight = Convert.ToInt32(Console.ReadLine()); //reads input and converts to an integer
            if (packWeight > 50) //if statement for if the package exceeds 50
            {
                Console.WriteLine("The package is too heavy to be shipped via Package Express. Have a good day!"); //message notifiying the user the item cannot be shipped
                return; //exits the program since the item is not eligible for shipping
            }
            Console.WriteLine("Please enter the width of the package"); //prompts the user to enter the width of the package
            int packWidth = Convert.ToInt32(Console.ReadLine()); //reads input and converts to an integer
            Console.WriteLine("Please enter the height of the package"); //prompts the user to enter the height of the package
            int packHeight = Convert.ToInt32(Console.ReadLine()); //reads input and converts to an integer
            Console.WriteLine("Please enter the length of the package"); //prompts the user to enter the height of the package
            int packLength = Convert.ToInt32(Console.ReadLine()); //reads input and converts to an integer
            int dimensions = packWidth + packHeight + packLength; //dimensions assigned as an integer to take the input of the dimensions
            if (dimensions > 50) //if statement for the dimensions exceeding 50
            {
                Console.WriteLine("Package is too big to be shipped via Package Express"); //notifies user the package is too big too be shipped
                return; //exits the program since the item is not eligible for shipping
            }
            int totalDimensions = packHeight * packWidth * packLength; //totalDimensions assigned as an int that multiplies the dimensions together
            double priceToShip = (totalDimensions * packWeight) / 100; //assigned as a double incase its necessary, takes the dimensions mulitplied by the weight & divided by 100 to determine the shipping cost
            Console.WriteLine($"The cost to ship your package is ${priceToShip}."); //displays the shipping cost to the user as a dollar value
            Console.ReadLine(); //program stays open until the user hits enter or exits by other means 
        }
    }
}
