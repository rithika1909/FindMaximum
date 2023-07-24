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

            bool flag = true;

            Console.WriteLine("Enter the size of  array:");
            int size = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("Enter the datatype:\n 1.Integer\n 2.Float\n 3.String\n 4.Exit");
            while (flag)
            {
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        int[] array = new int[size];
                        for (int i = 0; i < size; i++)
                        {
                            array[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        genericOperation.FindMax<int>(array);
                        break;
                    case 2:
                        float[] Farray = new float[size];
                        for (int i = 0; i < size; i++)
                        {
                            Farray[i] = Convert.ToSingle(Console.ReadLine());
                        }
                        genericOperation.FindMax<float>(Farray);
                        break;
                    case 3:
                        string[] Sarray = new string[size];
                        for (int i = 0; i < size; i++)
                        {
                            Sarray[i] = Console.ReadLine();
                        }
                        genericOperation.FindMax<string>(Sarray);
                        break;
                    case 4:
                        flag = false;
                        break;
                    default:
                        break;

                }
            }
        }
    }
}
