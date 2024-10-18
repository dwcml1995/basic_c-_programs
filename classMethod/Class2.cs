using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classMethod
{
    public static class Class2 //declared class static
    {
        public static void twoParams(int inpNum, out int result) //method has an output paramater
        {
            result = inpNum * 15; //takes the input * 15 
        }
    }
}
