using System;

namespace Exercise_12
{
	class Program
	{
		static void Main(string[] args)
		{
			char copy = (char)0x169;

			Console.WriteLine("    " + copy + "    ");
			Console.WriteLine("   " + copy + " " + copy + "   ");
			Console.WriteLine("  " + copy + "   " + copy + "  ");
			Console.WriteLine(" " + copy + "     " + copy + " ");
			Console.WriteLine ("{0} {0} {0} {0} {0}", copy);		
		}
	}
}
