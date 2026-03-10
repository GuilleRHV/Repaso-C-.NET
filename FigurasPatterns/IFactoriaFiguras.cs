using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FigurasPatterns
{
    public interface IFactoriaFiguras
    {
        IFigura dameInstancia(TipoFiguras tipoFiguras);
    }
}