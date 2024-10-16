using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Class1
    {
        public void Operation (int num1, int num2)  //method that takes in 2 integers to perform a math operation
        {
            int result = num1 + 15; //added result variable as an int and assigned the value to num1 + 15 
            Console.WriteLine($"The result of {num1} + 15 is {result}"); //console prints the result of num1 + 15 and assigns that to result
            Console.WriteLine($"The second integer is, {num2}"); //displays value of num2
        }
    }
}
