using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            while(number <= 99)
            {
                if(number == 99)
                {
                    Console.Write("{0}\n", number);
                    break;
                }
                Console.Write("{0:D2}, ", number);
                number++;
            }
        }
    }
}
