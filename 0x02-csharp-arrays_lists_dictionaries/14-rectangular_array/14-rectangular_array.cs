using System;


    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[5,5];
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    if ((i == 2) && (j == 2))
                        array[i,j] = 1;
                    else
                        array[i,j] = 0;
                    if (j == 4)
                        Console.WriteLine("{0}", array[i,j]);
                    else
                        Console.Write("{0} ", array[i, j]);
                }
            }
        }
    }