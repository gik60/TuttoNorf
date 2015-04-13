using System;

namespace Exercise_22
{
	class Program
	{
		static void Main (string[] args)
		{
			Console.WriteLine ("Enter the x coordinate of point P");
			int x = Convert.ToInt32 (Console.ReadLine ());

			Console.WriteLine ("Enter the y coordinate of point P");
			int y = Convert.ToInt32 (Console.ReadLine ());

			int position = (x * x) + (y * y);

			if (position < 25) 
				Console.WriteLine ("The point P ({0},{1}) is inside the circle centered in O(0,0) with radius = 5", x, y);

			else
				Console.WriteLine ("The point P ({0},{1}) is NOT inside the circle centered in O(0,0) with radius = 5", x, y);
		}
	}
}
