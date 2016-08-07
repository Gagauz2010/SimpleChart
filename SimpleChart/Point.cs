using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleChart
{
    class Point
    {
        double X { get; set; }
        double Y { get; set; }

        public Point (double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}
