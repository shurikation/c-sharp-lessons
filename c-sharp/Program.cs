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
			double UsdToRub = 66.39;
			double UsdToUah = 27.24;
			double USD;

			Console.WriteLine("Enter USD: ");

			USD = double.Parse(Console.ReadLine());

			Console.WriteLine(USD + "in UAH =" + USD * UsdToUah);
			Console.WriteLine(USD + "in RUB =" + USD * UsdToRub);

			Console.ReadLine();
		}
	}

}






