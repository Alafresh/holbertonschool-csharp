using System;

namespace _3_print_alphabt
{
    class Program
    {
        static void Main(string[] args)
        {
            for(char a = 'a'; a <= 'z'; a++)
            {
                if (a == 'e')
                    continue;
                if (a == 'q')
                    continue;
                Console.Write(a);
            }
        }
    }
}
