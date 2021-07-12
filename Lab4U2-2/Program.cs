using System;

namespace Lab4U2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0;
            while (true)
            {
                Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
                Console.WriteLine(k);
                
                var text = Console.ReadLine();
                if (text == "stop")
                {
                    Console.WriteLine("Цикл остановлен");
                    break;
                }
                
                switch (text)
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Your fav color is RED!");
                        break;

                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Your fav color is green!");
                        break;

                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Your fav color is cyan...");
                        break;

                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Your color(yeah, just color) is yellow");
                        break;
                }
                k++;
            }
        }
    }
}
