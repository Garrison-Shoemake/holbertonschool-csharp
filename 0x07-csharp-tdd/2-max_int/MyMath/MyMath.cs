using System;
using System.Collections.Generic;

namespace MyMath
{
    public class Operations
    {

        public static int Max(List<int> nums)
        {
            if (myList == null || myList.Count == 0)
            {
                return 0;
            }
            myList.Sort();
            return myList[myList.Count - 1];
        }
    }
}
