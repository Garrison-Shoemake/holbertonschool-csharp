using System;


class Array
{
    public static int elementAt(int[] array, int index)
    {
        if (index < 0)
        {
            System.Console.WriteLine("Index out of range");
            return -1;
        }
        else if (index > array.Length - 1)
        {
            System.Console.WriteLine("Index out of range");
            return -1;
        }
        else
        {
            return array[index];
        }        
    }
}

