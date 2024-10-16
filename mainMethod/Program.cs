using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mainMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1(); //instantiate the class
            Console.WriteLine(class1.Operation(9)); //calls method 1 with int param
            Console.WriteLine(class1.Operation(14.73m)); //calls method 2 with decimal param
            Console.WriteLine(class1.Operation("15")); //calls method 3 with string param
            Console.ReadLine(); //keeps window open until user hits enter/exits
        }
    }
}
