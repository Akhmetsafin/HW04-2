using System;

namespace ReMake_FIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Количество вводимых позиций: ");
            int menCount = Convert.ToInt32(Console.ReadLine());
            //string[,] dbFIO = new string[menCount, 3];
            string[] Db = new string[menCount];
            for (int i = 0; i< menCount;i++)
            {
                Console.Write("\nВведите фамилию: ");
                string firstName = Console.ReadLine();
                Console.Write("Введите имя: ");
                string name = Console.ReadLine();
                Console.Write("Введите отчество: ");
                string patronymic = Console.ReadLine();
                Db[i]= GetMe_Name (firstName, name, patronymic);
                
            }
            Console.WriteLine($"\nВывод данных:\n");

            for (int j=0;j< menCount;j++)
            
            {
                Console.WriteLine(Db[j]);
            }

           
            Console.WriteLine();
        }


        public static string GetMe_Name(string surname, string name, string patronymic)
        {
            return $"{surname} {name} {patronymic}";
        }
    }
}
