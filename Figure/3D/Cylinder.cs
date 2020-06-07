using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorFigure.Figure
{
    class Cylinder : Figure3D
    {
        private int _height;
        private Circle _circle;                 
        public int Height
        {
            get => _height;
            set
            {
                if (value > 0)
                {
                    _height = value;
                }
            }
        }
        public Circle Circle
        {
            get => _circle;
            set
            { 
                    _circle = value;
               
            }
        }


    }
}
