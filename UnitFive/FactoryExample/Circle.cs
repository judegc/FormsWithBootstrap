using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample
{
    public class Circle : IShape
    {
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double Radius { get; set; }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public void Draw()
        {
            Console.WriteLine("This is a circle!"); ;
        }
    }
}
