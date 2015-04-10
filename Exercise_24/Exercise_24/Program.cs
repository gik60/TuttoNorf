using System;

namespace Exercise_24
{
	class Program
	{
		static void Main (string[] args)
		{
			Console.WriteLine ("Enter a four digit number"); //any digit after the fourth will not be considered
			int number;
	
			while (true) {
				string numtry = Console.ReadLine ();
				if (numtry.Length != 4) {
					Console.WriteLine ("The entered number has not four digits, try again:");
				} else {
					number = Convert.ToInt32 (numtry);
					break;
				}
			}
			//separate the four digits
			int d = number % 10;
			int c = (number / 10) % 10;
			int b = (number / 100) % 10;
			int a = (number / 1000) % 10;

			//sum of digits
			int sum = a + b + c + d;
			Console.WriteLine ("The sum of the digits {0}{1}{2}{3} is {4}", a, b, c, d, sum);

			//print in the reverse order
			Console.WriteLine ("The reverse number is: {0}{1}{2}{3} ", d, c, b, a);

			//Last digit first position
			Console.WriteLine ("The number with the last digit in the first position is: {0}{1}{2}{3} ", d, a, b, c);

			//Excange second and third
			Console.WriteLine ("The number with the second and the third digits swapped is: {0}{1}{2}{3} ", a, c, b, d);
		}
	}
}
