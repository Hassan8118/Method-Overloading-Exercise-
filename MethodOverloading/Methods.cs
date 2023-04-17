using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class Methods
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static decimal Add(decimal a, decimal b)
        { 
            return a + b; 
        }   
        public static string Add(int a, int b, bool c)
        {
            if (c && (a+b) != 1)
            {
                return ($"{a+b}");
            }
            else if (c && (a+b) == 1)
            {
                return ($"{a + b} dollar");
            }
            else 
            {
                return ($"{a + b}");
            }
        }
    }
}
