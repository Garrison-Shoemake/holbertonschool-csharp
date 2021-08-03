using System;

///<summary>New generic class Queue, emulating an actual Queue class</summary>
public class Queue<T>
{
    ///<summary>Head of the queue</summary>
    public Node head;
    ///<summary>Tail of the queue</summary>
    public Node tail;
    int count = 0;

    ///<summary>Returns the type of the Queue given</summary>
        public Type CheckType()
    {
        return typeof(T);
    }
///<summary>Count returns the count of the nodes in the queue</summary>
    public int Count()
    {
        return count;
    }
    ///<summary>Adds a new node to the end of the queue</summary>
    public void Enqueue(T value)
    {
        if (head == null)
        {
            head = new Node(value);
        }
        else
        {
            tail = new Node(value);
            head.next = tail;
        }
        count++;
    }
///<summary>Class for holding the data for a node</summary>
    public class Node
    {
        ///<summary>Points to the next node in queue</summary>
        public Node next = null;
        ///<summary>Value of the </summary>
        public T value;
        ///<summary>Sets the nodes value</summary>
        public Node(T value)
        {
            this.value = value;
        }
    }


}

