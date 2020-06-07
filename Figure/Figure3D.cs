using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorFigure.Figure
{
    abstract class Figure3D : Figure
    {
        private double _volume;

        public double Volume
        {
            get => _volume;
            set
            {
                if (value > 0)
                {
                    _volume = value;
                }
            }
        }
    }
}
