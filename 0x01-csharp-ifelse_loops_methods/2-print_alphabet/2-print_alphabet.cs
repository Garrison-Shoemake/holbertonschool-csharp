using System;

namespace _2_print_alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 97;
            while (i < 123)
            {
                Console.Write((char)i);
                i++;
            }
        }
    }
}
