using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLib
{
    /// <summary>
    /// треугольник с тремя сторонами
    /// </summary>
    public  class Triangle : IFigure
    {
        public float a { get; set; }
        public float b { get; set; }
        public float c { get; set; }

        public List<float> sortedLines = new List<float>();

        bool valid = false;

        /// <summary>
        /// конструктор по умолчанию
        /// </summary>
        public Triangle() {
            a = 0;
            b = 0;
            c = 0;
            PrepaireLines();
        }
        /// <summary>
        /// треугольник с тремя сторонами
        /// </summary>
        /// <param name="a">сторона a</param>
        /// <param name="b">сторона b</param>
        /// <param name="c">сторона с</param>
        public Triangle(float a, float b, float c)
        {
            this.a = (a < 0) ? 0 : a;
            this.b = (b < 0) ? 0 : b;
            this.c = (c < 0) ? 0 : c;
            PrepaireLines();
        }

        /// <summary>
        /// функция подготовки сторон
        /// </summary>
        private void PrepaireLines (){
            sortedLines.Add(a);
            sortedLines.Add(b);
            sortedLines.Add(c);
            sortedLines.Sort();
            checkValid();
        }

        
        /// <summary>
        /// расчет площади по формуле Герона
        /// </summary>
        /// <returns>площадь</returns>
        public double calcArea()
        {
            if (!valid)
                return 0;
            float halfP = sortedLines.Sum()/2;
            return Math.Sqrt(halfP*(halfP - sortedLines[0]) * (halfP - sortedLines[1]) * (halfP - sortedLines[2]));
        }

        /// <summary>
        /// проверка валидности труегольника
        /// </summary>
        /// <returns></returns>
        private void checkValid() {
            if (sortedLines[0] + sortedLines[1] <= sortedLines[2])
                valid = false;
            else
                valid = true;
        }

        /// <summary>
        /// проверка на прямоугольность
        /// </summary>
        /// <returns></returns>
        public bool isRight() {
            //тут спорно, является ли например треугольник с нулевыми сторонами прямоугольным?
            if(!valid)
                return false;
            return Math.Pow(sortedLines[2], 2) == Math.Pow(sortedLines[0], 2) + Math.Pow(sortedLines[1], 2);
        }
        public override string ToString()
        {
            return $"Triangle. Lines: {a},{b},{c}. {((valid)?"Valid":"Invalid")}. {((isRight())?"Right":"Not right")}. Sorted: {sortedLines[0]}, {sortedLines[1]}, {sortedLines[2]}";
        }
    }
}
