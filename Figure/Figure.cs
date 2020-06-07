using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorFigure.Figure
{
    abstract class Figure
    {
        private double _area;

        public double Area
        {
            get => _area;
            set
            {
                if (value > 0)
                {
                    _area = value;
                }
            }
        }

    }
}
