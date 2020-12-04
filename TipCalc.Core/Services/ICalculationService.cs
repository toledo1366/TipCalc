using System;
using System.Collections.Generic;
using System.Text;

namespace TipCalc.Core
{
    public interface ICalculationService
    {
        double TipAmount(double subTotal, int generosity);
    }
}
