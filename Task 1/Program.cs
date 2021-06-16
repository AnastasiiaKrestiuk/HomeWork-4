using System;
using System.Text;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string lastName1 = "Ivanov";
            string firstName1 = "Ivan";
            string patronomic1 = "Ivanovich";

            string lastName2 = "Petrov";
            string firstName2 = "Petr";
            string patronomic2 = "Petrovich";

            string lastName3 = "Sidorov";
            string firstName3 = "Sidor";
            string patronomic3 = "Sidorovich";

            Console.WriteLine(GetFullName(lastName1, firstName1, patronomic1));
            Console.WriteLine(GetFullName(lastName2, firstName2, patronomic2));
            Console.WriteLine(GetFullName(lastName3, firstName3, patronomic3));
        }

        public static string GetFullName(string lastName, string firstName, string patronymic)
        {
            StringBuilder result = new StringBuilder($"{lastName} {firstName} {patronymic}");

            return result.ToString();
        }
    }
}
