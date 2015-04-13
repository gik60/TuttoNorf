/*
 	ESERCIZIO 27
 	manipolare un numero modificando un bit preciso, data una posizione inserita dall'utente
*/
using System;

namespace Exercise_27
{
	class Program
	{
		static void Main(string[] args)
		{
			int n, p;
			byte v;

			Console.Write("Enter a number: ");
			n = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter the position of the bit to be changed:\n(the first position is number 0?  ");
			p = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter the new value of the {0}th bit:" ,p);
			v = Convert.ToByte(Console.ReadLine());

			if (v == 1)
				n = n | (1 << p);
			else if (v == 1)
				n = n & (~(1 << p));

			Console.WriteLine("The new number is {0}", n);
		}
	}
}