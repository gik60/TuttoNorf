using System;

namespace Exercise_04
{
	class Program
	{
		static void Main (string[] args)
		{
			double Number_1;
			double Number_2;

			Console.WriteLine("Insert the first number");
			Number_1 = Convert.ToDouble(Console.ReadLine());//acquire the input from the user and save as first number

			Console.WriteLine("Insert the second number");
			Number_2 = Convert.ToDouble(Console.ReadLine());//acquire the input from the user and save as second number

			bool equal = Math.Abs (Number_1 - Number_2) < 0.000001;

			if (equal)
				Console.WriteLine ("The two numbers are eqaul with an accuracy of 0.000001");
			
			else
				Console.WriteLine ("The two numbers are not equal");
		}
	}
}
