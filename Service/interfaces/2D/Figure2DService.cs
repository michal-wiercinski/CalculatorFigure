using System;


namespace CalculatorFigure.Service.interfaces
{
    abstract class Figure2DService<T> : IFigureService<T>, IFigure2DService
    {
       virtual public T create(int param)
        {
            throw new NotImplementedException();
        }
        virtual public T create(int param, int param1)
        {
            throw new NotImplementedException();
        }
        virtual public double calculateCircuit(int param)
        {
            throw new NotImplementedException();
        }
        virtual public double calculateArea(int param, int param1)
        {
            throw new NotImplementedException();
        }
        virtual public double calculateArea(int param)
        {
            throw new NotImplementedException();
        }
    
    }
}
