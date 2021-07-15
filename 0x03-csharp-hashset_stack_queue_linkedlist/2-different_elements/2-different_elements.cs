using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        HashSet<int> first = new HashSet<int>(list1);
        HashSet<int> second = new HashSet<int>(list2);
        first.SymmetricExceptWith(second);
        List<int> retList = new List<int>(first);
        return retList;

    }
}

