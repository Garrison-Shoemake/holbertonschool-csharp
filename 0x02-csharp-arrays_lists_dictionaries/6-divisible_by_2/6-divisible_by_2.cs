using System;
using System.Collections.Generic;
class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> bools = new List<bool>();
        foreach (int number in myList)
        {
            if (number % 2 == 0)
            {
                bools.Add(true);
            }
            else
            {
                bools.Add(false);
            }
        }
        return bools;
    }
}

