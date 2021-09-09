using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons
{
	class Program
	{
		static void Main(string[] args)
		{
			//Интересный способ объявления цикла for с несколькими переменными и условиями
			//Переменные также можно вынести за цикл и работать с ними
			for (int i = 0, j = 5; i < 10 && j < 20; i++, j++) {  }

			int param1 = 5;
			int param2 = 10;
			//Тернарный оператор в C#:
			bool result = param1 == param2 ? true : false;

			//Массив.Все элементы массива должны быть одного и того же типа:
			int[] myArray; //Объявление
			//Пока мы объявили но не выделили память - он имеет 
			//Выделяем место в оперативной памяти heap
			myArray = new int[5]; //5 элементов типа int 0 0 0 0 0 - 0 это дефолтное значение
			//Или так 5 элементов:
			int[] myArray2 = new int[5] { 10, 20, 30, 40, 50 };

			//Можно не указывать количество элементов:
			int[] myArray3 = new int[] { 10, 20, 30, 40, 50, 60, 70 };
			//или
			int[] myArray4 = new[] { 10, 20, 30, 40, 50, 60, 70 };
			//или
			int[] myArray5 = { 10, 20, 30, 40, 50, 60, 70 };

			//Создание массива из 10 элементов и в каждом 5 - ка:
			int[] myArray6 = Enumerable.Repeat(5, 10).ToArray();

			//Создание массива с 5 элементами и начиная с 4 - ки[4, 5, 6, 7, 8]
			int[] myArray7 = Enumerable.Range(4, 5).ToArray();	
		}
	}
}






 