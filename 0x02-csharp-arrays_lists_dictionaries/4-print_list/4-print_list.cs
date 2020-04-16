﻿using System;
using System.Collections.Generic;

namespace _4_print_list
{
    class List
    {
        public static List<int> CreatePrint(int size)
        {
            if ( size < 0)
            {
                Console.WriteLine("Size cannot be negative");
                return null;
            }
            List<int> numbers = new List<int>();
            for (int i = 0; i < size; i++)
            {
                numbers.Add(i);
                if (i == size - 1)
                {
                    Console.WriteLine("{0}",numbers[i]);
                }
                Console.Write("{0} ", numbers[i]);
            }
            return numbers;
        }
    }
}
