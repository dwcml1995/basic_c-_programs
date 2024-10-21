using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Number num1 = new Number(8.92m); //creates an object of the data type Number and assigns an amount to it in decimal 
            Console.WriteLine($"The amount is: {num1.Amount}"); //prints the amount
            Console.ReadLine(); //keeps console open 
        }
    }
}
