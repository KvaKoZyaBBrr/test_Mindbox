using System;

namespace FigureLib
{
    /// <summary>
    /// интерфейс "фигура". Все кто реализует этот интерфейс должны умет ьсчитать площадь
    /// </summary>
    public interface IFigure
    {
        public double calcArea();
        public string ToString();
    }
}
