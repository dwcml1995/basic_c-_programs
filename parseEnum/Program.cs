using System;

namespace ParsingEnum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //prompt the user for input
                Console.WriteLine("Please enter the current day of the week:");
                string userInput = Console.ReadLine(); //get user input

                //declare the variable for the day
                DaysOfWeek day;

                //check the user input against the DaysOfWeek enum values
                if (userInput.Equals("Monday", StringComparison.OrdinalIgnoreCase))
                {
                    day = DaysOfWeek.Monday;
                }
                else if (userInput.Equals("Tuesday", StringComparison.OrdinalIgnoreCase))
                {
                    day = DaysOfWeek.Tuesday;
                }
                else if (userInput.Equals("Wednesday", StringComparison.OrdinalIgnoreCase))
                {
                    day = DaysOfWeek.Wednesday;
                }
                else if (userInput.Equals("Thursday", StringComparison.OrdinalIgnoreCase))
                {
                    day = DaysOfWeek.Thursday;
                }
                else if (userInput.Equals("Friday", StringComparison.OrdinalIgnoreCase))
                {
                    day = DaysOfWeek.Friday;
                }
                else if (userInput.Equals("Saturday", StringComparison.OrdinalIgnoreCase))
                {
                    day = DaysOfWeek.Saturday;
                }
                else if (userInput.Equals("Sunday", StringComparison.OrdinalIgnoreCase))
                {
                    day = DaysOfWeek.Sunday;
                }
                else
                {
                    Console.WriteLine("Invalid day entered.");
                    return; //exit if input is invalid
                }

                //output the valid day
                Console.WriteLine($"You entered: {day}");
                Console.WriteLine($"Numeric value: {(int)day}");

            }
            catch (Exception ex) //catch any exception that occurs
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            //keeps the console open
            Console.ReadLine();
        }

        public enum DaysOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}