using System;
namespace FigureLib
{
    /// <summary>
    /// круг. Имеет только радиус
    /// </summary>
    public class Circle : IFigure
    {
        public float radius { get; set; }

        /// <summary>
        /// конструктор по умолчанию
        /// </summary>
        public Circle() {
            radius = 0;
        }

        /// <summary>
        /// конструктор с радиусом
        /// </summary>
        /// <param name="radius">собственно радиус</param>
        public Circle(float radius)
        {
            if (radius < 0) 
                this.radius = 0;
             else
                this.radius = radius;
        }

        /// <summary>
        /// расчет площади
        /// </summary>
        /// <returns>площадь</returns>
        public double calcArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public override string ToString()
        {
            return $"Circle. Radius = {radius}";
        }
    }
}
