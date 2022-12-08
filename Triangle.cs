using System;

namespace Figures
{
    /// <summary>
    /// Класс для работы с прямоугольником
    /// </summary>
    public class Rectangle:IPerimetrSquary, IComparable
    {
        /// <summary>
        /// Поля для прямоугольника
        /// </summary>
        double _sideA;
        double _sideB;

        int _square;
        

        /// <summary>
        /// конструктор для прямоугольника
        /// </summary>
        /// <param name="sideA"></param>
        /// <param name="sideB"></param>
        public Rectangle (double sideA, double sideB)
        {
            _sideA = sideA;
            _sideB = sideB;
        }

        /// <summary>
        /// Метод для нахождения периметра прямоугольника
        /// </summary>
        /// <returns></returns>
        public double Perimetr()
        {
           return (_sideA + _sideB) * 2;

        }

        /// <summary>
        /// Метод для нахождения площади прямоугольника
        /// </summary>
        /// <returns></returns>
        public double Square()
        {
            return _sideA * _sideB;
        }

        /// <summary>
        /// Метод сравнения 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            Rectangle r = (Rectangle)obj;           
            if (this._square > r._square) return 1;
            if (this._square < r._square) return -1;           
            return 0;
        }

        /// <summary>
        /// Поверхностное клонирование
        /// </summary>
        /// <returns></returns>
        public Rectangle ShallowClone()
        {
            return(Rectangle)this.MemberwiseClone();
        }
    }
}
