using System;

namespace _10_print_line
{
    class Line
    {
        public static void PrintLine(int length)
        {
            string line = "_";
            if (length <= 0)
                Console.Write("\n");
            for (int i = 1; i <= length; i++)
            {
                Console.Write(line);
            }
        }
    }
}
