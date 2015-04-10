using System;

namespace Exercise_18
{
	class Program
	{
		static void Main (string[] args)
		{
			Console.WriteLine("Enter a number:");
			int number = Convert.ToInt32(Console.ReadLine());
			bool bit3 = (number & 8) != 0; 

			if (bit3) {
				Console.WriteLine ("The third bit of {0} is 1", number);
			} else {
				Console.WriteLine ("The third bit of {0} is 0", number);
			}
		}
	}
}
