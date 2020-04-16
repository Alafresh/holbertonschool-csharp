using System;
using System.Collections.Generic;

    class List
    {
        public static List<int> CreatePrint(int size)
        {
            if ( size < 0)
            {
                Console.WriteLine("Size cannot be negative");
                return null;
            }
            if (size == 0)
            {
                Console.Write("\n");
                List<int> myList = new List<int>();
                return myList;
            }
            List<int> numbers = new List<int>();
            for (int i = 0; i < size; i++)
            {
                numbers.Add(i);
                if (i == size - 1)
                {
                    Console.WriteLine("{0}",numbers[i]);
                    break;
                }
                Console.Write("{0} ", numbers[i]);
            }
            return numbers;
        }
    }
