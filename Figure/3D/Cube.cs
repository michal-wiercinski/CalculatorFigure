using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorFigure.Figure
{
    class Cube : Figure3D
    {
        private Square _square;
    
        public Square Square
        {
            get => _square;
            set 
            {
                   _square = value;                
            }
        }
    }
}
