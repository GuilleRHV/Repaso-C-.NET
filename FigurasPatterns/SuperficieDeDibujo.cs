using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FigurasPatterns
{
    public class SuperficieDeDibujo : IColeccion
    {
        List<IFigura> figuras = new List<IFigura>();
         double areaTotal = 0;
        double perimetroTotal = 0;
        public void add(IFigura figura)
        {
            figuras.Add(figura);
            areaTotal += figura.Area();
            perimetroTotal += figura.Perimetro();
        }

        public double dameAreaTotal()
        {
            return areaTotal;
        }

        public double damePerimetroTotal()
        {
            return perimetroTotal;
        }
    }
}