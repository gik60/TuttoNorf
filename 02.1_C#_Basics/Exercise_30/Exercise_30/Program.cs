using System;

namespace Exercise_30
{
	class Program
	{
		static void Main (string[] args)
		{
			Console.WriteLine("Enter a number");
			int n = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter p starting bit");
			int p = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter q starting bit");
			int q = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter a range of bit");
			int range = Convert.ToInt32(Console.ReadLine());

			int start_position;
			int end_position;

			string binary = Convert.ToString(n, 2);
			Console.WriteLine(binary);

			for (int i = 0 ; i < range ; i++) 
			{ 

				start_position = (n >> p) & 1; 
				end_position = (n >> q) & 1; 

				n = n & (~(1 << q)) | (start_position << q); 
				n = n & (~(1 << p)) | (end_position << p); 
				p++; 
				q++; 
			}
			binary = Convert.ToString(n, 2);
			Console.WriteLine(binary);
		}
	}
}
