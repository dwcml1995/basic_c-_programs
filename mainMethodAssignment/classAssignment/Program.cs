using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Class1 mathOperation = new Class1(); //instantiated class 
            mathOperation.Operation(14, 11); //called the method and passed in two numbers
            mathOperation.Operation(num1: 15, num2: 33); //called the method & specified the parameters by their name and assigned values
        }
    }
}