using System;

namespace _11_print_diagonal
{
    class Line
    {
       public static void PrintDiagonal(int length)
       {
            string space = "";
            string diagonal = "\\";
            if (length <= 0)
                Console.Write("\n");
            for(int i = 1; i <= length; i++)
            {
                Console.WriteLine("{0}{1}", space, diagonal);
                space += " ";
            }
       }
    }
}
