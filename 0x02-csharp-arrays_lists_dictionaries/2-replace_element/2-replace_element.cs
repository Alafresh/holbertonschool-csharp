using System;

namespace _2_replace_element
{
    class Array
    {
        public static int[] ReplaceElement(int[] array, int index, int n)
        {
            if(index < 0 || index >= array.Length)
            {
                Console.WriteLine("Index out of range");
                return array;
            }
            array[index] = n;
            return array;
        }
    }
}
