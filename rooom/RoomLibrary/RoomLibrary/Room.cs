using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomLibrary
{
    public class Room
    {
        double roomLength;
        double roomWidth;
        public double RoomLength
        {
            get { return roomLength; }
            set { roomLength = value; }
        }
        public double RoomWidth
        {
            get { return roomWidth; }
            set { roomWidth = value; }
        }
        /// <summary>
        /// Метод вычисляет периметр комнаты
        /// </summary>
        /// <returns>Возвращает значение периметра</returns>
        public double RoomPerimeter()
        {
            return 2 * (RoomLength + RoomWidth);
        }
        public double RoomArea()
        {
            return roomLength * roomWidth;
        }
        /// <summary>
        /// вычисляет число кв. метров на человека
        /// </summary>
        /// <param name="np"></param>
        /// <returns>Возвращает число кв. метров</returns>
        public double PersonArea(int np)
        {
            return RoomArea() / np;
        }
    }
}