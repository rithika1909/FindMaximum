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
        }
    }
}
