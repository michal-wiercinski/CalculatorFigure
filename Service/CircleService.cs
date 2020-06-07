using CalculatorFigure.Figure;
using CalculatorFigure.Service.interfaces;
using System;


namespace CalculatorFigure.Service
{
    class CircleService : Figure2DService<Circle>
    {
        override public double calculateArea(int radius)
        {
            return Math.PI * Math.Pow(2, radius);
        }
        override public double calculateCircuit(int radius)
        {
            return 2 * Math.PI * radius;
        }
        override public Circle create(int radius)
        {
            Circle circle = new Circle();
            circle.Radius = radius;
            circle.Area = calculateArea(radius);
            circle.Circuit = calculateCircuit(radius);

            return circle;
        }
    }
}