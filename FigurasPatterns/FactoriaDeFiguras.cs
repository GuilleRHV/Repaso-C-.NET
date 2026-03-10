using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FigurasPatterns
{
    public class FactoriaDeFiguras : IFactoriaFiguras
    {
        public IFigura dameInstancia(TipoFiguras tipoFiguras)
        {
            switch (tipoFiguras)
            {
                case TipoFiguras.Circulo:
                    {
                        return new Circulo();
                    }

                case TipoFiguras.Cuadrado:
                    {
                        return new Cuadrado();
                    }

                default:
                    {
                        return null;
                    }


            }
        }
    }
}