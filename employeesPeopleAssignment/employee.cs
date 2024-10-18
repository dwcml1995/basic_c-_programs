using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employees_people
{
    public class employee : person //employee class that inherits props from person class
    {
        public int id {  get; set; } //set the property for id
    }
    public virtual void SayName() //implemented the sayname method in the class 
}
