using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace mainMethod
{
    public class Class1
    {
        public int Operation(int num) //first method to take in an integer
        {
            return num / 7;
        }
        public int Operation(decimal num) //second method to take in a decimal
        {
            int newNum = Convert.ToInt32(num);
            return newNum * 22;
        }
        public int Operation(string num) //third method to take in a string
        {
            int newNum = Convert.ToInt32(num);
            return newNum - 33;
        }
    }
}