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
        if (aStack.Count == 0)
        {
            System.Console.WriteLine("Stack is empty");
        }
        else
        {
            System.Console.WriteLine("Top item: {0}", aStack.Peek());
        }
        System.Console.WriteLine("Stack contains \"{0}\": {1}", search, aStack.Contains(search));
        while (aStack.Contains(search) == true)
        {
            aStack.Pop();
        }
        aStack.Push(newItem);
        return aStack;
    }
}

