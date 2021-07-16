using System;
using System.Collections.Generic;
using System.Linq;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        try
        {
            myLList.Remove(myLList.ElementAt(index));
        }
        catch{
            return;
        }
    }
}

