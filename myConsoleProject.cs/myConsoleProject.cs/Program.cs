using System;

namespace myConsoleProject
{
    class Program
    {
        static void Main()
        {
            // Your code goes here
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");
            Console.Read();
        }
    }
}
