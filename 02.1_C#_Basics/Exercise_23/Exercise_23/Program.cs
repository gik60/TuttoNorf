/*
 	ESERCIZIO 23
 	dato un punto p (x, y) calcolare se è interno al cerchio di raggio 5 centrato nell'origine e contemporaneamente fuori dal rettangolo con -1<x<5, 1<y<5.
*/
using System;

namespace Exercise_23
{
	class Program
	{
		static void Main(string[] args)
		{
			double x, y;

			Console.WriteLine("Enter a point P=(x,y):");						// mi faccio dare le coordinate del punto

			Console.Write("x: ");
			x = Convert.ToDouble(Console.ReadLine());

			Console.Write("y: ");
			y = Convert.ToDouble(Console.ReadLine());

			bool withinCircle = (x * x) + (y * y) <= 25;						// withinCircle=true se l'ipotenusa del triangolo con cateti x e y è minore del quadrato del raggio
			bool withinRect = (x <= 5) && (x >= -1) && (y <= 5) && (y >= 1);	// withinRect=true se sia x che y sono compresi tra le ascisse e le ordinate limite dei lati
			if (withinCircle && !withinRect)									// stampa se è interno al cerchio e esterno al rettangolo
				Console.WriteLine ("The point P=({0},{1}) is inside the circle and outside the rectangle", x, y);
		}
	}
}