using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
	class Point
	{
		public int x;
		public int y;
		public char sym;

		public Point()
		{
		}

		public Point(int x, int y, char sym)//вызов функции для создания точки
		{
			this.x = x;
			this.y = y;
			this.sym = sym;
		}

		public Point(Point p)//конструктор чтобы задавать точку при помощи другой
		{
			x = p.x;
			y = p.y;
			sym = p.sym;
		}

		public void Move(int offset, Direction direction)//конструктор для передвижения точек в определенных направлениях
		{
			if (direction == Direction.RIGHT)
			{
				x = x + offset;
			}
			else if (direction == Direction.LEFT)
			{
				x = x - offset;
			}
			else if (direction == Direction.UP)
			{
				y = y - offset;
			}
			else if (direction == Direction.DOWN)
			{
				y = y + offset;
			}
		}

		public bool IsHit(Point p)//метод, который проверяет есть пересечение координат
		{
			return p.x == this.x && p.y == this.y;
		}

		public void Draw()//отрисовка точек
		{
			Console.SetCursorPosition(x, y);
			Console.Write(sym);//рисует символ змейки, то есть ее тело 
		}

		public void Clear()//удаление точку
		{
			sym = ' ';
			Draw();//рисует пробел
		}

		public override string ToString()
		{
			return x + ", " + y + ", " + sym;
		}
	}
}
