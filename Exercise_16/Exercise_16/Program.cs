using System;

namespace Exercise_16
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Insert a number");
			int number = int.Parse(Console.ReadLine());
			int check_5 = number % 5;
			int check_7 = number % 7;

			if (check_5 == 0 && check_7 == 0) {
				Console.WriteLine ("{0} is divisible by both 5 and 7", number);
			} else {
				Console.WriteLine ("{0} is not divisible by both 5 and 7", number);
			}

		}
	}
}
