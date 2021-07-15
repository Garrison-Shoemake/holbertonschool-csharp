using System;
using System.Collections.Generic;
class LList
{
    public static LinkedListNode<int> Add(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> newfirst = myLList.AddFirst(n);
        return newfirst;
    }
}