using CalculatorFigure.Figure;
using CalculatorFigure.Service.interfaces._3D;
using System;

namespace CalculatorFigure.Service
{
    class CubeService :  Figure3DService<Cube>
    {
        override public double calculateArea(int side)
        {
            return 6 * Math.Pow(side, 2);
        }
        override public double calculateVolume(int side)
        {
            return Math.Pow(side, 3); 
        }
    }
}
