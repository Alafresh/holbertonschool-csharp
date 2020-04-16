﻿using System;

namespace _3_print_array_reverse
{
    class Array
    {
       public static void Reverse(int[] array)
       {
            if(array == null || array.Length == 0)
            {
                Console.Write("\n");
                return;
            }
            for(int i = array.Length - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    Console.WriteLine("{0}", array[i]);
                    break;
                }
                Console.Write("{0} ", array[i]);
            }
       }
    }
}
