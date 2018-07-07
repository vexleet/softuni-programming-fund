using System;
using System.Linq;

public class SequenceOfCommands_broken
{
    private const char ArgumentsDelimiter = ' ';

    public static void Main()
    {
        int sizeOfArray = int.Parse(Console.ReadLine());

        long[] array = Console.ReadLine()
            .Split(ArgumentsDelimiter)
            .Select(long.Parse)
            .ToArray();

        string command = Console.ReadLine();

        while (!command.Contains("stop"))
        {
            //string line = Console.ReadLine().Trim();
            int[] args = new int[2];

            if (command.Contains("lshift"))
            {
                array = ArrayShiftLeft(array);
            }
            else if (command.Contains("rshift"))
            {
                array = ArrayShiftRight(array);
            }
            else
            {
                string[] stringParams = command.Split(ArgumentsDelimiter);
                args[0] = int.Parse(stringParams[1]);
                args[1] = int.Parse(stringParams[2]);
                array = PerformAction(array, stringParams[0], args);
            }

            PrintArray(array);

            Console.WriteLine("");

            command = Console.ReadLine();
        }
    }

    static long[] PerformAction(long[] arr, string action, int[] args)
    {
        long[] array = arr.Clone() as long[];
        int pos = args[0];
        int value = args[1];

        switch (action)
        {
            case "multiply":
                array[pos - 1] *= value;
                break;
            case "add":
                array[pos - 1] += value;
                break;
            case "subtract":
                array[pos - 1] -= value;
                break;
        }
        return array;
    }

    private static long[] ArrayShiftRight(long[] array)
    {
        long tmp = array[array.Length - 1];
        for (int i = array.Length - 1; i >= 1; i--)
        {
            array[i] = array[i - 1];
        }
        array[0] = tmp;    
        return array;
    }

    private static long[] ArrayShiftLeft(long[] array)
    {
        var tmp = array[0];
        for (var i = 1; i < array.Length; i++)
        {
            array[i - 1] = array[i];
        }
        array[array.Length - 1] = tmp;
        return array;
    }

    private static void PrintArray(long[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}
