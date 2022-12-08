using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    /// <summary>
    /// Определяет периметр и площадь фигур
    /// </summary>
    internal interface IPerimetrSquary
    {
        int CompareTo(object obj);
        double Perimetr();
        double Square();
    }
}
