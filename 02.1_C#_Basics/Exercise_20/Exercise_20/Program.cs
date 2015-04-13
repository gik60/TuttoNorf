using System;

namespace Exercise_20
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Enter the side of the rectangle in cm:");
			int side = Convert.ToInt32 (Console.ReadLine ());

			Console.WriteLine ("Enter the height of the rectangle in cm:");
			int height = Convert.ToInt32 (Console.ReadLine ());

			int area = side * height;

			Console.WriteLine ("The area of the rectangle with side = {0}cm and height = {1}cm is {2}cm^2", side, height, area);

		}
	}
}
