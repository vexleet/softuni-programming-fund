using System;

namespace ReverseArray_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrayLength = int.Parse(Console.ReadLine());
            int[] array = new int [arrayLength];
            for(var i = 0; i < arrayLength; i++)
            {
                int number = int.Parse(Console.ReadLine());
                array[i] = number;
            }

            Console.WriteLine(ReverseArray(array));
        }

        static string ReverseArray(int[] array)
        {
            string result = "";

            for (var i = array.Length - 1; i >= 0; i--)
            {
                result += array[i] + " ";

            }
            return result;
        }
    }
}
