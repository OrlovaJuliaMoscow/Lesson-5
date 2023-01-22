using System;

namespace Find_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random random = new Random();
            bool f = false;
            for (int i = 0; i < 10; i++)
            {
                array[i] = random.Next(0, 10);
                Console.WriteLine("{0} ", array[i]);
            }
            Console.WriteLine();
            foreach (int a in array)
            {
                if (a == 0)
                {
                    Console.WriteLine("found");
                    f = true;
                    break;
                }
            }
            if (!f)
                Console.WriteLine("not found");
            Console.ReadKey();
        }
    }
    
}
