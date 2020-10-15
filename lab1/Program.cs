using System;

namespace lab1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Здравствуйте, введите пожалуйста ваше имя");
            string name = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(name))
            {
                name = "неизвестно";
            }
            Console.WriteLine("Введите вашу дату рождения");
            int day, month, year;
            while (true)
            {
                Console.Write("1)День = ");

                if (CheckInt(Int32.TryParse(Console.ReadLine(), out day))) continue;
                Console.Write("2)Месяц = ");
                if (CheckInt(Int32.TryParse(Console.ReadLine(), out month))) continue;
                Console.Write("3)Год = ");
                if (CheckInt(Int32.TryParse(Console.ReadLine(), out year))) continue;
                break;
            }
            
            Console.WriteLine($"Ваше имя - {name}");
            Console.WriteLine($"Ваша дата рождения - {day}.{month}.{year} ");
            Console.WriteLine("Приятно познакомиться");
        } 
        static bool CheckInt(bool temp)
        {
            if (!temp)
            {
                Console.WriteLine("вы ввели не правильное число!!!!!!!!!!!!!!!!!!!");
                return true;
            }
            return false; ;
        }
    }
}
