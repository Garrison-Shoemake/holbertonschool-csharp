using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            System.Console.WriteLine("Size cannot be negative");
            return null;
        }
        var numbers = new List<int> {};
        int index;

        for (index = 0; index < size; index++)
        {
            numbers.Add(index);
            System.Console.Write("{0}", numbers[index]);
            if (index < size - 1)
            {
                System.Console.Write(" ");
            }
        }
        System.Console.WriteLine();
        return numbers;
    }
}
