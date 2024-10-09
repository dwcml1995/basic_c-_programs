using System;

namespace MathAndComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("What is your hourly rate?");
            string hourlyRate1 = Console.ReadLine();
            Console.WriteLine("How many hours do you work per week?");
            string hours1 = Console.ReadLine();
            int salary1 = Convert.ToInt32(hourlyRate1) * Convert.ToInt32(hours1) * 52;

            Console.WriteLine("Person 2");
            Console.WriteLine("What is your hourly rate?");
            string hourlyRate2 = Console.ReadLine();
            Console.WriteLine("How many hours do you work per week?");
            string hours2 = Console.ReadLine();
            int salary2 = Convert.ToInt32(hourlyRate2) * Convert.ToInt32(hours2) * 52;

            Console.WriteLine("The annual salary of the first person is: " + salary1);
            Console.WriteLine("The annual salary of the second person is: " + salary2);
            bool isTrue = salary1 > salary2;
            Console.WriteLine("The first person makes more than the second person: " + isTrue);
            Console.ReadLine();
        }
    }
}