using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
	class VerticalLine : Figure
	{
		public VerticalLine(int yUp, int yDown, int x, char sym) //создание линии поля для игры
		{
			pList = new List<Point>();
			for (int y = yUp; y <= yDown; y++)//цикл отрисовки точек
			{
				Point p = new Point(x, y, sym);//создание точек на определенных координатах
				pList.Add(p);
			}
		}
	}
}
