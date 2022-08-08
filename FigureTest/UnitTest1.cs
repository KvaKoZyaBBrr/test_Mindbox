using FigureLib;

namespace FigureTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<IFigure> listFigure = new List<IFigure>();
            listFigure.Add(new Circle());
            listFigure.Add(new Circle(0));
            listFigure.Add(new Circle(10));
            listFigure.Add(new Circle(7.5f));
            listFigure.Add(new Circle(5000000));
            listFigure.Add(new Circle(-5000000));
            listFigure.Add(new Circle(-10));

            listFigure.Add(new Triangle());
            listFigure.Add(new Triangle(0,0,0));
            listFigure.Add(new Triangle(10,10,10));
            listFigure.Add(new Triangle(0,10,-10));
            listFigure.Add(new Triangle(0, 10, 0));
            listFigure.Add(new Triangle(1, 2, 3));
            listFigure.Add(new Triangle(5, 13, 12));
            listFigure.Add(new Triangle(2, 2, 3));
            listFigure.Add(new Triangle(2.5f, 2.5f, 3));
            listFigure.Add(new Triangle(-10,-10,-10));
            listFigure.Add(new Triangle(100000,100000,100000));

            foreach (IFigure fig in listFigure) {
                double area = fig.calcArea();
                Console.WriteLine($"{fig.ToString()}. Area {area}");
                Assert.IsTrue(area >= 0);
            }
        }
    }
}