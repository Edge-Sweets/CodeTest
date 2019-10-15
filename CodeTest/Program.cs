using CodeTest.Models;
using System;
using System.Collections.Generic;

namespace CodeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape fiveUnitRectangle = CreateFiveUnitRectangle();
            Shape triangle = CreateTriangle();

            TestModel test1 = new TestModel(1, fiveUnitRectangle, new System.Drawing.Size(50, 50));
            TestModel test2 = new TestModel(1, triangle, new System.Drawing.Size(50, 50));
        }

        /// <summary>
        /// Determine where each part will fit on the given Rectangle (in testModel).
        /// 
        /// </summary>
        /// <param name="test">test to evaluate</param>
        /// <returns>list of complete shapes, each with where they should start</returns>
        private List<Shape> GetInsertedShapePositions(TestModel test)
        {

        }


        private static Shape CreateFiveUnitRectangle()
        {
            Shape fiveUnitRectangle = new Shape();
            fiveUnitRectangle.ShapePoints.Add(new Point(0, 0));
            fiveUnitRectangle.ShapePoints.Add(new Point(0, 5));
            fiveUnitRectangle.ShapePoints.Add(new Point(5, 5));
            fiveUnitRectangle.ShapePoints.Add(new Point(5, 0));
            fiveUnitRectangle.ShapePoints.Add(new Point(0, 0));
            return fiveUnitRectangle;
        }

        private static Shape CreateTriangle()
        {
            Shape triangle = new Shape();
            triangle.ShapePoints.Add(new Point(0, 0));
            triangle.ShapePoints.Add(new Point(5, 5));
            triangle.ShapePoints.Add(new Point(10, 0));
            triangle.ShapePoints.Add(new Point(0, 0));
            return triangle;
        }
    }
}
