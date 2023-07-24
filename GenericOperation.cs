using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMax
{
    public class GenericOperation
    {
        public void FindMax<T>(T[] array)
        {
            Array.Sort(array);
            PrintMax(array.Max());
           
        }
        public void PrintMax<T>(T max)
        {
            Console.WriteLine("Max Value:" + max);
        }






    }
}
