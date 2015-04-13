using System;

namespace Exercise_10
{
	class Program
	{
		static void Main (string[] args)
		{

			string s1 = "The \"use\" of quotations causes difficulties."; // Escaping character

			string s2 = @"The ""use"" of quotations causes difficulties.";// Verbatim

			Console.WriteLine("{0}\n{1}", s1, s2);
		
		}
	}
}
