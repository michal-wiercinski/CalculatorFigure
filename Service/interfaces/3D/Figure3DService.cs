using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorFigure.Service.interfaces._3D
{
    abstract class Figure3DService<T> : IFigureService<T>, IFigure3DService
    {
        virtual public T create(int param)
        {
            throw new NotImplementedException();
        }
        virtual public T create(int param, int param1)
        {
            throw new NotImplementedException();
        }
        virtual public double calculateArea(int param)
        {
            throw new NotImplementedException();
        }
        virtual public double calculateVolume(int param)
        {
            throw new NotImplementedException();
        }
        virtual public double calculateArea(int param, int param1)
        {
            throw new NotImplementedException();
        }
        virtual public double calculateVolume(int param, int param1)
        {
            throw new NotImplementedException();
        }
    }
}
