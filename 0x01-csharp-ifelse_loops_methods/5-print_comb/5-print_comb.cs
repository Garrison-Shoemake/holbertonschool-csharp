using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 100)
            {                
                if (i < 99)
                {
                    Console.Write("{0:D2}, ", i);
                }
                else 
                {
                    Console.WriteLine("{0:D2}", i);
                }            
                i++;
            }
        }
    }
}
