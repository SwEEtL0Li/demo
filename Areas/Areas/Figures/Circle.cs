using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Areas.Figures
{
    public class Circle : Interfaces.InAreas
    {
        public int Rad { get; set; }

        public double Area => PI * Pow(Rad, 2);

        public Circle()
        {
            Rad = default(int);
        }
        public Circle(int rad) 
        {
            Rad = rad;
        }
    }
}
