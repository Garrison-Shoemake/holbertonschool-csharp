using System;


class Array
{
    public static int[] ReplaceElement(int[] array, int index, int n)
    {
        if (index > array.Length - 1)
        {
            System.Console.WriteLine("Index out of range");
            return array;
        }
        else if (index < 0)
        {
            System.Console.WriteLine("Index out of range");
            return array;

        }
        else
        {
            array[index] = n;
            return array;
        }
    }
}

