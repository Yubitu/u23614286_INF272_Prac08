using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u23614286_INF272_Prac08.Models
{
    //Adapted ellipse class using lecture sample code 13 as reference
    public class Ellipse : Shape
    {
        private int mX;
        private int mY;
        private int mMajorAxis;
        private int mMinorAxis;

        public int X { get => mX; set => mX = value; }
        public int Y { get => mY; set => mY = value; }
        public int MajorAxis { get => mMajorAxis; set => mMajorAxis = value; }
        public int MinorAxis { get => mMinorAxis; set => mMinorAxis = value; }

        public Ellipse()
        {
        }

        public Ellipse(string desc, string fill, string sColour, double sWidth, int major, int minor, int x, int y)
            : base(desc, fill, sColour, sWidth)
        {
            MajorAxis = major;
            MinorAxis = minor;
            X = x;
            Y = y;
        }

        public override double getArea()
        {
            return Math.Round(Math.PI * (mMajorAxis / 2.0) * (mMinorAxis / 2.0), 2);
        }

        //return an svg string for the shape to be drawn. in this case, an elipse has a major axis and a minor axis
        public override string getSVG()
        {
            return "<svg style='border: 1pt dashed #333' height='" + base.SvgHeight + "' width='" + base.SvgWidth + "'>" +
                   "<ellipse cx='" + mX + "' cy='" + mY + "' rx='" + mMajorAxis + "' ry='" + mMinorAxis + "' " +
                   "style='fill:" + base.Fill + ";stroke:" + base.StrokeColour + ";stroke-width:" + base.StrokeWidth + "' /></svg>";
        }
    }

}