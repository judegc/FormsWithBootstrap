using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample
{
    public class Rectangle : IShape
    {
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public double Length { get; set; }
        public double Width { get; set; }
        public double CalculateArea()
        {
            return Length * Width;
        }

        public void Draw()
        {
            Console.WriteLine("This is a rectangle!"); ;
        }
    }
}
