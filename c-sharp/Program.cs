using System;
using System.Globalization; //Просторанство имён
/**
 * #6 - Конвертация строки в число
 */
namespace Lessons
{
	class Program
	{
		static void Main(string[] args)
		{
			int a; 
			int b;

			Console.ReadLine(a);
			Console.ReadLine(b);

			double c = ((double)a + b) / 2;

			Console.WriteLine(c);
			Console.ReadLine();
		}
	}

}






