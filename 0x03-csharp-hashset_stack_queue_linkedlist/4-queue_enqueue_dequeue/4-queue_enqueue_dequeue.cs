using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        int count = 0;
        foreach (string value in aQueue)
        {
            count++;
        }
        System.Console.WriteLine("Number of items: {0}", count);
        if (aQueue.Count == 0)
        {
            System.Console.WriteLine("Stack is empty");
        }
        else
        {
            System.Console.WriteLine("First item: {0}", aQueue.Peek());
        }
        System.Console.WriteLine("Queue contains \"{0}\": {1}", search, aQueue.Contains(search));
        while (aQueue.Contains(search) == true)
        {
            aQueue.Dequeue();
        }
        aQueue.Enqueue(newItem);
        return aQueue;
    }
}
