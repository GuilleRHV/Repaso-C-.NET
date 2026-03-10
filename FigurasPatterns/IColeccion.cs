using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FigurasPatterns
{
    public interface IColeccion
    {
        double dameAreaTotal();
        void add(IFigura figura);
        double damePerimetroTotal();
    }
}