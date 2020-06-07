using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorFigure.Figure
{
    abstract class Figure2D : Figure
    {
        private double _circuit;
        public double Circuit
        {
            get => _circuit;
            set
            {
                if (value > 0)
                {
                    _circuit = value;
                }
            }
        }
    }
}
