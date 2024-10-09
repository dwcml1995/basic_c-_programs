using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //do while loop
            int count = 0;
            do
            {
                Console.WriteLine("Inside of the loop");
                count++; //increments by 1
            }
            while (count < 8); //while the count is below 8
            //while loop
            int counter = 0;
            while (counter < 8) ;                   //while the count is below 8
            {
                Console.WriteLine("We are counting!");
                counter++; //increments by 1
            }
            Console.ReadLine();
        }
    }
}

