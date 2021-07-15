using System;
using System.Collections.Generic;

    class List
    {
        public static int Sum(List<int> myList)
        {
            int sum = 0;
            HashSet<int> adding = new HashSet<int>(myList);

            foreach (int number in adding)
            {
                sum += number;
            }
            return sum;
        }
    }

