using System;

namespace M4U1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

            var color = Console.ReadLine();

            if (color == "red")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Ваш цвет RED!");
            }

            else if (color == "green")
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Ваш цвет green!");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Ваш цвет cyan!");
            }
        }
    }
}
