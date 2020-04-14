using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i <= 9; i++)
            {
                for(int j = 1; j <= 9; j++)
                {
                    if (j == 9 && i == 8)
                    {
                        Console.WriteLine("{0}{1}", i, j);
                        break;
                    }
                    if (j > i)
                        Console.Write("{0}{1}, ", i, j);
                }
            }
        }
    }
}
