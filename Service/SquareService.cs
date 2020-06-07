using CalculatorFigure.Figure;
using CalculatorFigure.Service.interfaces;
using System;

namespace CalculatorFigure.Service
{
    class SquareService : Figure2DService<Square>
    {
        override public double calculateArea(int side)
        {
            return Math.Pow(side, 2);
        }
        override public double calculateCircuit(int side)
        {
            return 4 * side;
        }
    }
}

