using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorFigure.Service.interfaces
{
    interface IFigureService<T>
    {
        T create(int param, int param1);
        T create(int param);
        double calculateArea(int param , int param1);
        double calculateArea(int param);
    }
}
