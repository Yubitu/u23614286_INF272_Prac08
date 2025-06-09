using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u23614286_INF272_Prac08.Models
{
    public class Triangle : Shape
    {
        private int mX;
        private int mY;
        private int mBase;
        private int mHeight;

        public int X { get => mX; set => mX = value; }
        public int Y { get => mY; set => mY = value; }
        public int BaseLength { get => mBase; set => mBase = value; }
        public int Height { get => mHeight; set => mHeight = value; }

        public Triangle()
        {
        }

        public Triangle(string desc, string fill, string sColour, double sWidth, int baseLength, int height, int x, int y)
            : base(desc, fill, sColour, sWidth)
        {
            BaseLength = baseLength;
            Height = height;
            X = x;
            Y = y;
        }

        public override double getArea()
        {
            return 0.5 * mBase * mHeight;
        }

        public override string getSVG()
        {
            int x1 = mX;
            int y1 = mY + mHeight;

            int x2 = mX + (mBase / 2);
            int y2 = mY;

            int x3 = mX + mBase;
            int y3 = mY + mHeight;

            return "<svg style='border: 1pt dashed #333' height='" + base.SvgHeight + "' width='" + base.SvgWidth + "'>" +
                   "<polygon points='" + x1 + "," + y1 + " " + x2 + "," + y2 + " " + x3 + "," + y3 + "' " +
                   "style='fill:" + base.Fill + ";stroke:" + base.StrokeColour + ";stroke-width:" + base.StrokeWidth + "' /></svg>";
        }
    }

}