using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 mathOp = new Class1(); //instantiated the class
            Console.WriteLine("Please input a valid whole number to divide in half."); //prompt the user to input a number 
            int userInput =  Convert.ToInt32(Console.ReadLine()); //read & take their input and assign it to the variable
            mathOp.mathOperation(userInput);  //calling the mathOperation method on the number and print the users input
            Console.WriteLine("Please input another valid whole number to multiply by 15."); //prompt the user to input a number 
            int usersInput = Convert.ToInt32(Console.ReadLine()); //read & take their input and assign it to the variable
            int resultValue; //assign a variable for the result
            Class2.twoParams(usersInput, out resultValue); //since class2 is static, we call it in on the method, take in the users input and output the result value
            Console.WriteLine("The result of the operation is " + resultValue); //display the result on screen
            Console.WriteLine("Please enter a valid whole number to find the remainder of"); //prompt the user to input a number 
            int remainderInput = Convert.ToInt32(Console.ReadLine()); //read & take their input and assign it to the variable
            mathOp.calcRemainder(usersInput, remainderInput);  //calling the calcRemainder method on the number and print the users input
            Console.ReadLine(); //leaves program open 
        }
    }
}
