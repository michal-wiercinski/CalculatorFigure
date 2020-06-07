using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorFigure.Figure
{
    class Square : Figure2D
    {
        private int _side;
        public int Side
        {
            get => _side;
            set 
            {
                if (value > 0)
                {
                    _side = value;
                }
            }
        }
    }
}
