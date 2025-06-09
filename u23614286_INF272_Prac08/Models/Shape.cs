﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u23614286_INF272_Prac08.Models
{
    public abstract class Shape
    {
        public string Description { get; set; }
        public string Fill { get; set; }
        public string StrokeColour { get; set; }
        public double StrokeWidth { get; set; }
        public int SvgWidth { get; set; } = 450;
        public int SvgHeight { get; set; } = 450;

        public Shape()
        {

        }

        public Shape(string description, string fill, string strokeColour, double strokeWidth)
        {
            Description = description;
            Fill = fill;
            StrokeColour = strokeColour;
            StrokeWidth = strokeWidth;
        }

        public abstract double getArea();


        public abstract string getSVG();

    }
}