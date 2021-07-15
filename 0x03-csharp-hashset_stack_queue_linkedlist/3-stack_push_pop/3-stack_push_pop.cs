using System;
using System.Collections.Generic;
class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        int count = 0;
        foreach (string value in aStack)
        {
            count++;
        }
        System.Console.WriteLine("Number of items: {0}", count);
        if (aStack.Peek() == null)
        {
            System.Console.WriteLine("Stack is empty");
        }
        else
        {
            System.Console.WriteLine("Top item: {0}", aStack.Peek());
        }
        System.Console.WriteLine("Stack contains \"{0}\": {1}", search, aStack.Contains(search));  
        foreach (string thing in aStack)
        {
            string popped = aStack.Pop();
            if (popped == search)
            {
                break;
            }
        }
        aStack.Push(newItem);
        return aStack;
    }
}

