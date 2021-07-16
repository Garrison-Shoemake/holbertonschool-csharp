using System;
using System.Collections.Generic;
using System.Linq;
class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> current = myLList.First;
        LinkedListNode<int> newnode = new LinkedListNode<int>(n);
        if (current == null)
        {
            myLList.AddFirst(newnode);
            return newnode;
        }
        if (current.Value >=n)
        {
            myLList.AddBefore(current, newnode);
            return newnode;
        }
        while (current.Next != null && current.Next.Value < n)
        {
            current = current.Next;
        }
        myLList.AddAfter(current, newnode);
        return newnode;
    }
}
