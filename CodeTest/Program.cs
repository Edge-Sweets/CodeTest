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

            TestModel test1 = new TestModel(1, fiveUnitRectangle, new Size(50, 50));
            TestModel test2 = new TestModel(1, triangle, new Size(50, 50));

            List<Shape> placedShapes1 = GetInsertedShapePositions(test1);
            Console.WriteLine("Test1: ");
            foreach(var shape in placedShapes1)
            {
                Console.WriteLine(shape.ToString());
            }
            Console.WriteLine();
            List<Shape> placedShapes2 = GetInsertedShapePositions(test2);
            Console.WriteLine("Test2: ");
            foreach (var shape in placedShapes2)
            {
                Console.WriteLine(shape.ToString());
            }

        }

        /// <summary>
        /// TODO: Implement this
        /// Determine where each part will fit on the given Rectangle (in testModel).
        /// 
        /// </summary>
        /// <param name="test">test to evaluate</param>
        /// <returns>list of complete shapes, each with where they should start</returns>
        private static List<Shape> GetInsertedShapePositions(TestModel test)
        {
            return MySolution.GetInsertedShapePositions(test);
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
