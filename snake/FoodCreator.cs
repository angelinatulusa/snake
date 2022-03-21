using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
	class FoodCreator
	{
		int mapWidht;
		int mapHeight;
		char sym;

		Random random = new Random();

		public FoodCreator(int mapWidth, int mapHeight, char sym)
		{
			this.mapWidht = mapWidth; //ширина
			this.mapHeight = mapHeight; //высота
			this.sym = sym; //симвод еды
		}

		public Point CreateFood() //создание еды
		{
			int x = random.Next(2, mapWidht - 2);//генерация координат x
			int y = random.Next(2, mapHeight - 2);//генерация координат y
			return new Point(x, y, sym);//появление еды в месте с рандомными координатами
		}
	}
}
