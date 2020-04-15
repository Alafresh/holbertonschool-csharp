using System;

namespace _2_print_alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = 'a';
            while( a <= 'z')
            {
                Console.Write(a++);
            }
        }
    }
}
