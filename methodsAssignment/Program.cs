using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace callingMethods
{
    public class Program
    {
        static void Main(string[] args)
        {
            try //put the code into a try block for any exception handling
            {
                Console.WriteLine("Please select if you want to add, multiply or divide by entering 0, 1 or 2."); //provides clear instruction to the user and prompts them to make a decision
                int userInput = Convert.ToInt32(Console.ReadLine()); //reads their input and converts it to an integer
                Console.WriteLine("Please select a whole number to operate on"); //prompts the user to select a number
                int userOperation = Convert.ToInt32(Console.ReadLine()); //reaids their input and converts to an integer
                int result = 0; //initilaizies the result at 0

                switch (userInput) //switch statement to evaluate the variable and execute on the correct operation 
                {
                    case 0: 
                        result = Class1.Addition(userOperation); //takes class1 that contains the methods and adds it 
                        Console.WriteLine($"Result of addition = {result}"); //prints the result to the console
                        break; //break statement incase this was their selection and do not need to proceed to the next block of code

                    case 1:
                        result = Class1.Multiplication(userOperation); //takes class1 that contains the methods and multiplies it 
                        Console.WriteLine($"Result of multiplication = {result}"); //prints the result to the console
                        break;
                    case 2:
                        if (userOperation == 0)
                        {
                            Console.WriteLine("Please do not divide by 0"); //if statement, to say if the user enters 0, we will let them know it cannot be done
                        }
                        else
                        {
                            result = Class1.Division(userOperation); //takes class1 that contains the methods and divides it 
                            Console.WriteLine($"Result of division = {result}"); //prints the result to the console
                        }
                        break;
                    default:
                        Console.WriteLine("Please enter 0, 1 or 2"); //default message reminding the user to only enter 0, 1 or 2
                        break;
                }
            }
            catch (FormatException) //catch block, for a format exception
            {
                Console.WriteLine("Please enter a whole number"); //let the user know to only enter a whole number
            }
            catch (Exception ex) //general error message
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
