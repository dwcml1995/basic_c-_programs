using System;
using System.Linq; 
using studentsFinalAssignment;

namespace studentsFinalAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new StudentDB())
            {
                var student = new Student
                {
                    FirstName = "John",
                    LastName = "Doe",
                    Age = 20
                };

                context.Students.Add(student);
                context.SaveChanges();
                Console.WriteLine("Student added successfully!");

                var students = context.Students.ToList();
                Console.WriteLine("Current students in the database:");
                foreach (var s in students)
                {
                    Console.WriteLine($"Name: {s.FirstName} {s.LastName}, Age: {s.Age}");
                }
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}