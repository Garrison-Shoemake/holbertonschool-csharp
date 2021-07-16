using System;
using System.Collections.Generic;

class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        int ret = 0;
        LinkedListNode<int> head = myLList.First;
        ret = head.Value;
        return ret;
    }
}

