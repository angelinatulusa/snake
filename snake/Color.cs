using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    public class Color
    {
        public Color()
        { }
        public void ColorOfSnake()
        {
            Console.WriteLine("Для начала давай выберем цвет полей");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("синий");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("зеленый");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("желтый");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("красный");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Какой хочешь?");
            string color = Console.ReadLine();
            Console.WriteLine("Теперь цвет самой змейки(варианты цветов те же)");
        }
    }
}
