using System.Collections.Generic;

namespace snake
{
	class HorizontalLine : Figure
	{
		public HorizontalLine(int xLeft, int xRight, int y, char sym) //создание линии поля для игры
		{
			pList = new List<Point>();
			for (int x = xLeft; x <= xRight; x++)//цикл отрисовки точек
			{
				Point p = new Point(x, y, sym);//создание точек на определенных координатах
				pList.Add(p);
			}
		}
	}
}
