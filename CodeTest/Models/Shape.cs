﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CodeTest.Models
{
    public class Shape
    {
        /// <summary>
        /// The starting point to insert this shape at
        /// </summary>
        public Point StartingPoint;
        /// <summary>
        /// The points that make up this shape
        /// </summary>
        public List<Point> ShapePoints { get; set; }

        public Shape()
        {
            ShapePoints = new List<Point>();
        }

        public override string ToString()
        {
            return StartingPoint.X + "," + StartingPoint.Y;
        }
    }
}
