using System;
class Program
{
    static void Main(string[] args)
    {
        int[] numList = { 8, 17, 24, 74, 6 }; //list of integers
        Console.WriteLine("Please input a whole number to divide each number in the list by."); //prompts user to input a whole number and lets them know what we will do with it


        try
        {
            int userInput = Convert.ToInt32(Console.ReadLine()); //takes the users input as an integer, and assigns it to an integer & reads the line

            for (int i = 0; i < numList.Length; i++) //iterate over the list and add 1 as long as the numList is less than the length of the list
            {
                Console.WriteLine($"{numList[i]} divided by {userInput} is {numList[i] / userInput}"); //shows the user the results of their input 
            }
        }
        catch (DivideByZeroException ex) //exception if the user tries to divide by 0
        {
            Console.WriteLine($"Error: {"Please do not divide by 0."}"); //error message given to the user if they try to divide by 0
        }
        catch (FormatException ex) //format exception incase the user tries to input something like a string
        {
            Console.WriteLine($"Error: {"Please input a whole number."}"); //error message given to the user if they try to input anything but a whole number
        }
        catch (Exception ex) //general error message
        {
            Console.WriteLine($"Unexpected Error: {ex.Message}"); //generic error message
        }
        Console.WriteLine("The program has continued running"); //lets you know the try/catch block executed without getting into terms a user may not be familiar with 
        Console.ReadLine(); //program runs until user presses enter
    }
}