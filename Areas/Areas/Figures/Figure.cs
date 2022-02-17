using Areas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areas.Figures
{
    public class Figure : InAreas
    {
        private InAreas figure;
        public double Area => figure.Area;

        public Figure(InAreas figures) 
        {
            figure = figures;
        }
    }
}
