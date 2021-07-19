using System;
using System.Collections.Generic;

class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        int count = 0; 
        List<int> retlist = new List<int>();

        while (count < listLength)
        {
            int result = 0;
            try
            {
                result = list1[count] / list2[count];
                retlist.Add(result);
            }
            catch(DivideByZeroException)
            {
                System.Console.WriteLine("Cannot divide by zero");
                retlist.Add(result);
            }
            catch(ArgumentOutOfRangeException)
            {
                System.Console.WriteLine("Out of range");
            }
        count++;    
        }
        
        return retlist;
    }
}

