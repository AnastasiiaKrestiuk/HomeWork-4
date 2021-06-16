using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ведите, пожалуйста числа через пробел:");
            string listOfNumbers = Console.ReadLine();

            Console.WriteLine(GetSum(listOfNumbers));
        }

        public static int GetSum(string listOfNumbers)
        {
            string[] array = listOfNumbers.Split(' ');       //преобразую строку в массив строк с разделителем пробел

            int sum = 0;                                     //переменная для получения суммы
            int number;                                      //переменная для преобразования строки в число

            for (int i = 0; i < array.Length; i++)           //цикл для перебора элементов массива строк
            {
                if (Int32.TryParse(array[i], out number))    //проверка на возможность преобразования строки в число
                {
                    sum += number;
                }
            }

            return sum;
        }
    }
}
