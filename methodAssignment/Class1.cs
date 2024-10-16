using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodAssignment
{
    public class Class1
    {
        public int Operation(int num, int num2 = 8) //created method with one optional parameter
        {
            int result = num * num2; //perform a math operation
            return result;
        }
    }
}
