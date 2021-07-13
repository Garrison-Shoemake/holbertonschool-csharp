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
                if (i != 101 && i != 113){
                    Console.Write((char)i);
                }
                i++;
            }
        }
    }
}