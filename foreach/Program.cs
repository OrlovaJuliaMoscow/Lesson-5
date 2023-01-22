using System;

namespace foreach
{
    class Program
{
    static void Main(string[] args)
    {
        int[] array = { 4, 44, 5, 8 };
        foreach (int a in array)
        {
            Console.WriteLine(a);
        }
        Console.ReadKey();
    }
}
}
