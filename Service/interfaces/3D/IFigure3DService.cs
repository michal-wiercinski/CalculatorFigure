using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorFigure.Service.interfaces
{
    interface IFigure3DService
    {
        double calculateVolume(int param);
        double calculateVolume(int param, int param1);
    }
}
