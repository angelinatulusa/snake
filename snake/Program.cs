using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace snake
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8; //чтобы программа принимала русские буквы
			int score = 0;//переменная со счетом
			int speed = 2;//переменная со скоростью

			Console.SetBufferSize(250, 80);//установки размера окна

			Walls walls = new Walls(80, 25);
			walls.Draw();

			// Отрисовка точек			
			Point p = new Point(4, 5, '*');//создание точки
			Snake snake = new Snake(p, 4, Direction.RIGHT);//создание змейки из 4 точек и направление, куда змейка повернута
			snake.Draw();

			//создание еды
			FoodCreator foodCreator = new FoodCreator(80, 25, '$');
			Point food = foodCreator.CreateFood();
			food.Draw();
			
			while (true)
			{
				if (walls.IsHit(snake) || snake.IsHitTail())//конец игры в случае, если змейка коснулась своего тела или поля
				{
					/*string name;
					Console.WriteLine("Write your name: ");
					name = Console.ReadLine();
					//добавить имя и счет в файл*/
					Console.Write("Your score: {0}",score);
					break;
				}
				if (snake.Eat(food))//если змейка "съела" еду, то появляется новая еда и змейка становится длинее 
				{
					
					food = foodCreator.CreateFood();
					food.Draw();
					score++;
				}
				else
				{
					snake.Move();
				}
				Thread.Sleep(100);//скорость перемещения
                while (score==speed)
                {
					int a = 50;
					Thread.Sleep(100+a);
					speed++;
				}
				if (Console.KeyAvailable)
				{
					ConsoleKeyInfo key = Console.ReadKey();
					snake.HandleKey(key.Key);
				}
			}
			
			Console.ReadLine();
		}

	}
}
