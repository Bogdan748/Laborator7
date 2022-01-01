using System;

namespace Laborator7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1,2,3,4,5,6,7,8 };

            Console.WriteLine($"Max: {MaxVal(array)}");
            Console.WriteLine($"Min: {MinVal(array)}");

            int val = 3;
            Console.WriteLine($"Index of {val} is {IndexOf(array, val)}");
          
            Console.WriteLine($"Arithmetic mean: {ArithMean(array)}");
        }

        static int MaxVal(int[] array)
        {
            if (array.Length == 0) return 0;

            int max=array[0];

            for (int i=1; i < array.Length; i++)
            {
                max = Math.Max(max, array[i]);
            };

            return max;
        }

        static int MinVal(int[] array)
        {
            if (array.Length == 0) return 0;

            int min = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                min = Math.Min(min, array[i]);
            };

            return min;
        }

        static int IndexOf(int[] array, int val)
        {
            
            for (int i=0; i <= array.Length; i++)
            {
                if (array[i] == val) return i;
            }

            return 0;
        }

        static float ArithMean(int[] array)
        {
            float rezultat = 0;

            foreach (int val in array)
            {
                rezultat += val;
            }

            return rezultat / array.Length;
        }
    }
}
