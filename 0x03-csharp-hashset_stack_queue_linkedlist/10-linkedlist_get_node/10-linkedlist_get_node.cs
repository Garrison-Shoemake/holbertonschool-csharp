using System;
using System.Collections.Generic;
using System.Linq;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        try
        {
            return myLList.ElementAt(n);
        }
        catch
        {
            return 0;
        }
    }
}

