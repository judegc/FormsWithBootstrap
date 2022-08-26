using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample
{
    public static class ShapeFactory
    {
        public static IShape CreateShape(string shapeName)
        {
            switch (shapeName.ToLower())
            {
                case "rectangle":
                    return new Rectangle(2, 4);
                case "circle":
                    return new Circle(5);
                default:
                    return new Rectangle(1, 2);
            }
        }
    }
}
