using System;

namespace Exercise_04
{
	class Program
	{
		static void Main (string[] args)
		{
			double Number_1 = 1234.000001;
			double Number_2 = 1234;

			bool equal = Math.Abs (Number_1 - Number_2) < 0.000001;

			if (equal)
				Console.WriteLine ("The two numbers are eqaul with an accuracy of 0.000001");
			else
				Console.WriteLine ("The two numbers are not equal");
		}
	}
}
