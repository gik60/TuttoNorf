using System;

namespace Exercise_26
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			
			Console.WriteLine ("Enter an integer");
			int v = Convert.ToInt32 (Console.ReadLine ());

			Console.WriteLine ("Enter the position to be checked");
			int p = Convert.ToInt32 (Console.ReadLine ());

			bool check = (v & Convert.ToInt32 (Math.Pow (2, p))) != 0;//convert p in binary and check the p bit of v

			if (check) {
				Console.WriteLine ("The bit in position {0} of {1} is 1", p, v);
			} else {
				Console.WriteLine ("The bit in position {0} of {1} is 0", p, v);
			}
		}
	}
}
