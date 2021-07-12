using System;

class Program
{
	static void Main(string[] args)
	{
		string str = "Holberton School";
		Console.WriteLine("{0}{0}{0}", str);
        string newstr = str.Substring(0, 9);
        Console.WriteLine(newstr);
    }      
}