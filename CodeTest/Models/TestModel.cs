using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CodeTest.Models
{
    public class TestModel
    {

        public double Spacing { get; set; }
        public Shape Shape { get; set; }
        public Size RectangleSize { get; set; }


        public TestModel(double spacing, Shape shape, Size rectangleSize)
        {
            Spacing = spacing;
            Shape = shape;
            RectangleSize = rectangleSize;
        }

    }
}
