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
        public Size Rectangle { get; set; }


        public TestModel(double spacing, Shape shape, Size rectangle)
        {
            Spacing = spacing;
            Shape = shape;
            Rectangle = rectangle;
        }

    }
}
