using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Square sq = new Square();
            sq.draw();

            Rectangle rec = new Rectangle();
            rec.draw();

            Circle crc = new Circle();
            crc.draw();

            ShapeFactory fac = new ShapeFactory();

            Shape sh1 = fac.getShape("CIRCLE");
            sh1.draw();

            Shape sh2 = fac.getShape("REACTANGLE");
            sh2.draw();

            Shape sh3 = fac.getShape("SQUARE");
            sh3.draw();
        }
    }
}