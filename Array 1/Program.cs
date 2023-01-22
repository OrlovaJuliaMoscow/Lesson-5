using System;

namespace Array_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random random = new Random();
            int S = 0;
            for (int i = 0; i < 10; i++)
            {
                array[i] = random.Next(0, 10);
                S += array[i];
                Console.WriteLine("{0} ", array[i]);
            }
            Console.WriteLine();
            Console.WriteLine(S);
            Console.ReadKey();
        }
    }
}
