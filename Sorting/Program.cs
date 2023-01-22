using System;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] array = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(0, 10);
                Console.WriteLine("{0} ", array[i]);
            }
            Console.WriteLine();

            for (int i = 0; i < n-1; i++)
            {
                for (int j = i+1; j <10; j++)
                {
                    if (array[i]>array[j])
                    {
                        int t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}", array[i]);
            }
            Console.ReadKey();
        }
    }
    
}
