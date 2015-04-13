using System;

namespace Exercise_06
{
	class Program
	{
		static void Main (string[] args)
		{
			Char a;
			int b;

			a = 'H';
			b = Convert.ToInt16 (a);

			Console.WriteLine ("the Unicode character number {0} is: {1}", b, a);
		}
	}
}
