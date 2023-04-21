using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskShapes
{
    public static class ShapesUtilities
    {
        public static double GetShapeArea(IShape shape)
        {
            return shape.CalculateArea();
        }

        public static double GetShapePerimeter(IShape shape)
        {
            return shape.CalculatePerimeter();
        }
    }
}
