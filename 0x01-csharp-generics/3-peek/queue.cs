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
        Node insert = new Node(value);
        if (head == null)
        {
            head = insert;
            tail = insert;
        }
        else
        {
            tail.next = insert;
            tail = insert;
        }
        count++;
    }
///<summary>Removes the first node and returns its value</summary>
    public T Dequeue()
    {
        if (head == null)
        {
            System.Console.WriteLine("Queue is empty");
            return default(T);
        }

        T pop = head.value;
        head = head.next;
        count--;
        return pop; 
    }

    ///<summary>Returns the value of the first node</summary>
    public T Peek()
    {
        if (head == null)
        {
            System.Console.WriteLine("Queue is empty");
            return default(T);
        }
        return head.value;
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

