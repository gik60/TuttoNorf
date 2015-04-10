using System;

namespace Exercise_06
{
	class Program
	{
		static void Main (string[] args)
		{
			int a;
			char b;

			a = 72;
			b = Convert.ToChar (a);

			Console.WriteLine ("the Unicode character number {0} is: {1}", a, b);
		}
	}
}
