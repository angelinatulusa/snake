using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
	class Walls
	{
		List<Figure> wallList;

		public Walls(int mapWidth, int mapHeight)
		{
			wallList = new List<Figure>();

			// Отрисовка рамочки, учитывая указанные размеры
			HorizontalLine upLine = new HorizontalLine(0, mapWidth - 2, 0, '-');
			HorizontalLine downLine = new HorizontalLine(0, mapWidth - 2, mapHeight - 1, '-');
			VerticalLine leftLine = new VerticalLine(0, mapHeight - 1, 0, '=');
			VerticalLine rightLine = new VerticalLine(0, mapHeight - 1, mapWidth - 2, '=');
			//добавляем линии в список
			wallList.Add(upLine);
			wallList.Add(downLine);
			wallList.Add(leftLine);
			wallList.Add(rightLine);
		}

		internal bool IsHit(Figure figure)//проверка столкнулась ли змейка со стеной
		{
			foreach (var wall in wallList)
			{
				if (wall.IsHit(figure))//если змейка столкнулась со стеной, то запускается бесконечный цикл
				{
					return true;
				}
			}
			return false;//если нет, то игра идет дальше
		}

		public void Draw()//отрисовка поля
		{
			foreach (var wall in wallList)
			{
				wall.Draw();
			}
		}
	}
}
