using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
	class Snake : Figure//змейка - наследник еласс фигура
	{
		Direction direction;//хранение данных движения(направления)

		public Snake(Point tail, int length, Direction _direction)//конструктор, задающий точку появления змейки на поле и ее направление
		{
			direction = _direction;//переменная направлений
			pList = new List<Point>();//список точек
			for (int i = 0; i < length; i++)//цикл, где создается копия точки хвоста
			{
				Point p = new Point(tail);//добавление точек в определеноое место
				p.Move(i, direction);//движение точки
				pList.Add(p);//добавление точки в список pList
			}
		}

		public void Move()//движение змейки
		{
			Point tail = pList.First();//берем первый элемент из списка
			pList.Remove(tail);//удаляет последнюю точку, то есть хвост, чтобы змейка передвигалась по полю, а не просто увеличивалась
			Point head = GetNextPoint();//добавляем точку в начало змейки(голову) чтобы она передвигалась
			pList.Add(head);

			tail.Clear();//стерает последнюю точку(хвост)
			head.Draw();//добавляет точку в начало(голову)
		}

		public Point GetNextPoint()//функция, вычисляющая где окажется точка змейки
		{
			Point head = pList.Last();//изначальная позиция
			Point nextPoint = new Point(head);//копирование предидущей точки
			nextPoint.Move(1, direction);//движение точки по заданому направлению
			return nextPoint;
		}

		public bool IsHitTail()//функция в случае когда змейка столкнулась со своим телом
		{
			var head = pList.Last();
			for (int i = 0; i < pList.Count - 2; i++)//проверка совпадают ли координаты головы и точки теха
			{
				if (head.IsHit(pList[i]))
					return true;//если да, то попадаем в бесконечный цикл и игра закончена
			}
			return false;//если не врезался
		}

		public void HandleKey(ConsoleKey key)//нажатие клавиш
		{//узнаем на какую кнопку пользовтель нажал
			if (key == ConsoleKey.LeftArrow)
				direction = Direction.LEFT;
			else if (key == ConsoleKey.RightArrow)
				direction = Direction.RIGHT;
			else if (key == ConsoleKey.DownArrow)
				direction = Direction.DOWN;
			else if (key == ConsoleKey.UpArrow)
				direction = Direction.UP;
		}

		public bool Eat(Point food)//еда
		{
			Point head = GetNextPoint();
			if (head.IsHit(food))//если точка головы змейки равно точке где находится еда, то змейка поест
			{
				food.sym = head.sym;//змейки удлиняется
				pList.Add(food);
				return true;
			}
			else//если нет, то игра идет дальше, просто змейка не поела
			{
				return false;
			}
				
		}
	}
}
