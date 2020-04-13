using System;
using System.Linq;
class Program
{
	static void Main(string[] args)
	{
		string str = "Holberton School";
		Console.WriteLine(string.Concat(Enumerable.Repeat(str, 3)) + "\n" + str.Substring(0, 9));
	}
}