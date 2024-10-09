using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string one = "my name is"; 
            string two = "donavon";
            string three = "i love programming";
            Console.WriteLine(one + two + three);
            Console.WriteLine(three.ToUpper());

            StringBuilder sb = new StringBuilder();
            sb.Append("Sentence one. ");
            sb.Append("Sentence two. ");
            sb.Append("Sentence three. ");

            string result = sb.ToString();
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}