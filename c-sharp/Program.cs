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
			double a = 2; //нужно одну перемнную привести к дабл
			int b = 5;

			double result = (double) a / b; //int не хранит дробную часть
			//мы выполняем приведение к типу (double)
			Console.WriteLine(result);

			int a1 = 10;
			int b1 = 3;

			//int или просто число это int32, даже если число 5 не присовено в переменную
			int c = a + 5;

			int result1 = a1 % b1; //остаток от деления

		}
	}

}






