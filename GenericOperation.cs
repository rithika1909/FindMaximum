using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMax
{
    public class GenericOperation
    {
        public T FindMax<T>(T a, T b, T c)
        {
            Comparer<T> comparer = Comparer<T>.Default;

            T max = a;
            if (comparer.Compare(a, b) >= 0 && comparer.Compare(a, c) >= 0)
            {
                max = a;
                PrintMax(max);
            }
            if (comparer.Compare(b, c) >= 0 && comparer.Compare(b, a) >= 0)
            {
                max = b;
                PrintMax(max);
            }
            if (comparer.Compare(c, a) >= 0 && comparer.Compare(c, b) >= 0)
            {
                max = c;
                PrintMax(max);
            }
            return max;
        }
        public void PrintMax<T>(T max)
        {
            Console.WriteLine("Max Value:" + max);
        }






    }
}
