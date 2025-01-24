using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareLibrary
{
    public interface IShape
    {
        double Area();
        double Perimeter();
    }

    public class Square : IShape
    {
        
        
            public double Side { get; set; }

            public Square(double side)
            {
                if (side <= 0)
                {
                    throw new ArgumentException("Сторона квадрата должна быть положительным числом.");
                }
                Side = side;
            }

            public double Area()
            {
                return Side * Side;
            }

            public double Perimeter()
            {
                return 4 * Side;
            }
        

        double IShape.Area() => this.Area();
        double IShape.Perimeter() => this.Perimeter();
    }
}
