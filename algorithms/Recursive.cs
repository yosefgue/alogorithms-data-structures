using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithms
{
    public static class Recursive
    {
        public static int Factorial(int x)
        {
            if (x == 0) return 1;
            return x * Factorial(x - 1); 
        }
    }
}

/* 
The base case prevents the function from running infinitely.
When it’s reached, it returns 1 back to the top of the call stack.
Each waiting function then takes that value, uses it in its own calculation, and returns the result upward until the original call finishes.
this is a simpe case to understand how things work.
 */