using System;

namespace Exercise_14
{
	class Program
	{
		static void Main (string[] args)
		{
			int a = 5;
			int b = 10;
			int temp;

			Console.WriteLine("A and B before swapping: {0}\t{1}", a, b);

			temp = a;
			a = b;
			b = temp;

			Console.WriteLine("A and B after swapping: {0}\t{1}", a, b);

		}
	}
}
