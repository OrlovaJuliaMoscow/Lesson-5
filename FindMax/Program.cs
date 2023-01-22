using System;

namespace FindMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                array[i] = random.Next(0, 10);
                Console.WriteLine("{0} ", array[i]);
            }
            Console.WriteLine();
            int max = array[0];
            foreach(int a in array)
            {
                if (a > max)
                    max = a;
            }
            Console.WriteLine(max);
            Console.ReadKey();
        }
    }
    
}
