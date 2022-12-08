using System;

namespace Figures
{
        public class Circle: IPerimetrSquary, IComparable, ICloneable
    {
            /// <summary>
            /// поле для круга
            /// </summary>
            double _radius;

        int _square;

            /// <summary>
            /// конструктор для круга
            /// </summary>
            /// <param name="radius"></param>
            public Circle(double radius)
            {
                _radius = radius;
            }

            /// <summary>
            /// Метод для нахождения периметра круга
            /// </summary>
            /// <returns></returns>
            public double Perimetr()
            {
                return 2 * Math.PI * _radius;
            }

            /// <summary>
            /// Метод для нахождения площади круга
            /// </summary>
            /// <returns></returns>
            public double Square()
            {
                return Math.PI * Math.Pow(_radius, 2);
            }

        /// <summary>
        /// Метод сравнения
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            Circle c = obj as Circle;
            if (this._square > c._square) return 1;
            if (this._square < c._square) return -1;
            return 0;

        }

        /// <summary>
        /// Поверхностное клонирование
        /// </summary>
        /// <returns></returns>
        public Circle ShallowClone()
        {
            return (Circle)this.MemberwiseClone();
        }

        /// <summary>
        /// Полное клонирование
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            Circle c = new Circle(_radius);
            c._radius = this._radius;
            return c;
        }

        public override string ToString()
        {
            return $"{_radius}, { _square}";
        }

        
    }
}
