﻿using System;
using System.Collections.Generic;

class List
{
    public static int MaxInteger(List<int> myList)
    {
        if (myList == null)
        {
            System.Console.WriteLine("List is empty");
            return -1;
        }
        myList.Sort();
        return myList[myList.Count - 1];
    }
}
