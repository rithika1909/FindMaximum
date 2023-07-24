using System;
namespace FindMax
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation operation = new Operation();
            operation.FindMaxInteger(1, 2, 3);
            operation.FindMaxFloat(1.2f, 1.8f, 1.1f);
            operation.FindMaxString("a", "b", "c");

            GenericOperation genericOperation = new GenericOperation();
            Console.WriteLine("\n\nGeneric:\n");
            genericOperation.FindMax<int>(1, 2, 3);
            genericOperation.FindMax<float>(1.1f,1.9f,1.4f);
            genericOperation.FindMax<string>("a","b","c");
        }
    }
}
