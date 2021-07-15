using System;
using System.Collections.Generic;

class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        int count = 0;
        if (myLList.Contains(value) == false)
        {
            return -1;
        }
        foreach (int thing in myLList)
        {
            if (thing == value)
            {
                return count;
            }
            count++;
        }
        return count;
    }
}

