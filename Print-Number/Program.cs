using System;
namespace Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            i = 0;
            j = 0;
            for (i = 1; i <= 6; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}