using CalculatorFigure.Figure;
using CalculatorFigure.Service.interfaces;
using CalculatorFigure.Service.interfaces._3D;

namespace CalculatorFigure.Service
{
    class CylinderService :  Figure3DService<Cylinder>
    {
        Figure2DService<Circle> circleService = new CircleService();

        override public double calculateArea(int radius, int height)
        {
            Cylinder cylinder = create(radius, height);
         
            return cylinder.Area = (cylinder.Circle.Circuit * cylinder.Height) 
                + (2 * cylinder.Circle.Area);
        }
        override public double calculateVolume(int radius, int height)
        { 
            Cylinder cylinder = create(radius, height);

            return cylinder.Volume = circleService.calculateArea(cylinder.Circle.Radius) * cylinder.Height;
        }
        override public Cylinder create(int radius, int height)
        {
            Circle circle = circleService.create(radius);
            Cylinder cylinder = new Cylinder();
            cylinder.Height = height;
            cylinder.Circle = circle;

            return cylinder;
        }
    }
}
