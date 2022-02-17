using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Areas.Figures
{
    public class Triang : Interfaces.InAreas
    {
        public int Side1 { get; set; }
        public int Side2 { get; set; }
        public int Side3 { get; set; }

        public double Area
        {
            get
            {
                var p = (Side1 + Side2 + Side3) / 2;
                return Sqrt(p * (p - Side1) * (p - Side2));
            }
        }
        public Triang()
        {
            Side1 = Side2 = Side3 = default(int);
        }
        public Triang(int side1, int side2, int side3) 
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }
        public bool RightTriang() 
        {
            return (Side1 == Sqrt(Pow(Side2, 2) + Pow(Side3, 2))
                || Side2 == Sqrt(Pow(Side1, 2) + Pow(Side3, 2))
                || Side3 == Sqrt(Pow(Side1, 2) + Pow(Side2, 2)));
        }
    }
}
