using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMax
{
    public class Operation
    {
        public void FindMaxInteger(int a, int b, int c)
        {
            if (a >= b && a >= c)
                Console.WriteLine("a is max");
            if (b >= a && b >= c)
                Console.WriteLine("b is max");
            if (c >= a && c >= b)
                Console.WriteLine("c is max");
        }
        public void FindMaxFloat(float a, float b, float c)
        {
            if (a >= b && a >= c)
                Console.WriteLine("a is max");
            if (b >= a && b >= c)
                Console.WriteLine("b is max");
            if (c >= a && c >= b)
                Console.WriteLine("c is max");
        }
        public void FindMaxString(string a, string b, string c)
        {
            if (a.CompareTo(b) >= 0 && a.CompareTo(c) >= 0)
                Console.WriteLine("a is max");
            if (b.CompareTo(a) >= 0 && b.CompareTo(c) >= 0)
                Console.WriteLine("b is max");
            if (c.CompareTo(a) >= 0 && c.CompareTo(b) >= 0)
                Console.WriteLine("c is max");
        }
    }
}
