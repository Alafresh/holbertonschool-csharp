using System;

//namespace _0_print_array
//{
    class Array
    {
       public static int[] CreatePrint(int size)
       {
            if(size < 0)
            {
                Console.WriteLine("Size cannot be negative");
                return null;
            }
            int[] numbers = new int[size];
            for(int i = 0; i < size; i++)
            {
                numbers[i] = i;
                if (i == size - 1)
                {
                    Console.WriteLine("{0}", numbers[i]);
                    break;
                }
                Console.Write("{0} ", numbers[i]);
            }
            return numbers;
       }
    }
//}
