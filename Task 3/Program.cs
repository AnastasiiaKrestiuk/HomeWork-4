using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите, пожалуйста, номер месяца:");
            string entering = Console.ReadLine();
            int monthNumber;
            bool successe = Int32.TryParse(entering, out monthNumber);

            if (successe)
            {
                if (monthNumber > 0 && monthNumber < 13)
                {
                    Console.WriteLine(SeasonName(monthNumber));
                }

                else Console.WriteLine("Ошибка: введите число от 1 до 12.");
            }

            else Console.WriteLine("Ошибка: введите число от 1 до 12.");
        }

        public enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }

        public static Season SeasonName (int monthNumber)
        {
            Season name = (Season)0;
   
            if (monthNumber == 12 || monthNumber == 1 || monthNumber == 2)
            {
                name = (Season)3;
            }

            else if (monthNumber >= 3 && monthNumber <= 5)
            {
                name = (Season)0;
            }

            else if (monthNumber >= 6 && monthNumber <= 8)
            {
                name = (Season)1;
            }

            else if (monthNumber >= 9 && monthNumber <= 11)
            {
                name = (Season)2;
            }

            return name;
        }
    }
}
