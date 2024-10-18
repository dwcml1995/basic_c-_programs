using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classMethod
{
    public class Class1
    {
        public void mathOperation(int num) //void class that takes an integer
        {
            int numResult = num / 2; //divides input in half
            Console.WriteLine("The result of the equation is " + numResult); //displays the result on the console
        }
        public void calcRemainder(int num, int num1 = 15) //overloaded method, changed name of this method for clarity
        {
            int results = num % num1; //finds the remainder of the input on our 15
            Console.WriteLine("The remainder is " + results); //displays result to console
        }
    }
}
