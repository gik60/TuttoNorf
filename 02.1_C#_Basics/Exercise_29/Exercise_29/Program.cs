/*
	 ESERCIZIO 29
	 Exchange bit number 3, 4, 5 with the number 24, 25, 26 of a given 32 bit unsigned integer
*/using System;

namespace Exercise_29
{
	class Program
	{
		static void Main(string[] args)
		{
			int n, bit3, bit4, bit5, bit24, bit25, bit26;

			Console.Write("Enter a Number: ");
			n = Convert.ToInt32(Console.ReadLine());


			bit3 = (n >> 3) & 1;						// primo scambio: maschera i due bit per prenderli singolarmente
			bit24 = (n >> 24) & 1;
			n = n & (~(1 << 24)) | (bit3 << 24);		// e scambiali
			n = n & (~(1 << 3)) | (bit24 << 3);


			bit4 = (n >> 4) & 1;						// secondo scambio
			bit25 = (n >> 25) & 1;
			n = n & (~(1 << 25)) | (bit4 << 25);
			n = n & (~(1 << 4)) | (bit25 << 4);

			bit5 = (n >> 5) & 1;						// terzo scambio
			bit26 = (n >> 26) & 1;
			n = n & (~(1 << 26)) | (bit5 << 26);
			n = n & (~(1 << 5)) | (bit26 << 5);

			Console.WriteLine("{0} is the new number.", n);
		}
	}
}