using System;


class Array
{
    public static int[] CreatePrint(int size)
    {
//        if (size == 0)
//        {
//            Console.Write("");
//        }
        if (size < 0)
        {
            System.Console.Write("Size cannot be negative");
        }
        int[] array = new int[size];
        for (int pos = 0; pos < size; pos++)
        {
           Console.Write("{0} ", pos);
        }
        System.Console.WriteLine();
        return array;
    }
}