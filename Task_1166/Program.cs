using System;

namespace Task_1166
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте. Я - Олег. Программа которая находит цифру, на которую оканчивается число A^B");

            Console.WriteLine("Введите число A");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число B");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Результат: ");
            Console.WriteLine( d = Marh.Pow(a,b));
            int c = (d)%10;
            Console.WriteLine("Ответ: ");
            Console.WriteLine(c);
        }
    }
}
