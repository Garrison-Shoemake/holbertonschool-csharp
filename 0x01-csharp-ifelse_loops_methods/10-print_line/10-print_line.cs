﻿using System;


class Line
{
    public static void PrintLine(int length)
    {
        int i = 0;
        if (length < 0)
        {
            Console.Write("");
        }
        while (i < length)
        {
            Console.Write("_");
            i++;
        }
        Console.Write("\n");
    }
}

