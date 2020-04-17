using System;

class Program
{
    static void Main(string[] args)
    {
        int[][] jaggedArray3 = 
        {
            new int[] {0, 1, 2, 3},
            new int[] {0, 1, 2, 3, 4, 5, 6},
            new int[] {0, 1}
        };
        for(int i = 0; i < jaggedArray3.Length; i++)
        {
            for(int j = 0; j < jaggedArray3[i].Length; j++)
            {
                if(j == jaggedArray3[i].Length - 1)
                    Console.WriteLine("{0}", jaggedArray3[i][j]);
                else
                    Console.Write("{0} ", jaggedArray3[i][j]);
            }
        }
    }
}

