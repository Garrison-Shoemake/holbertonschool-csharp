using System;


class Array
{
    public static void Reverse(int[] array)
    {
        int index;
        if (array == null)
        {
            System.Console.WriteLine();
        }
        for (index = array.Length - 1; index >= 0; index--)
        {
            if (index == 0)
            {
                System.Console.Write("{0}", array[index]);
            }
            else
            {
                System.Console.Write("{0} ", array[index]);
            }
        }
        System.Console.WriteLine();
    }
}

