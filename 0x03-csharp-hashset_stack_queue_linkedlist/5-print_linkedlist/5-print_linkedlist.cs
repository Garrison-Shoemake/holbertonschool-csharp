using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> llist = new LinkedList<int>();
        int i = 0;

        while (i < size)
        {
            llist.AddFirst(i);
            System.Console.WriteLine(i);
            i++;
        }

        return llist;
    }
}

