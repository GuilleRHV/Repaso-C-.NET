using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FigurasPatterns
{
    public class Circulo : IFigura
    {
        private int _radio = 3;
        public int radio
        {
            get => _radio;
            set
            {
                _radio = value;
            }
        }

        public double Area()
        {
            return Math.PI * radio * radio;
        }

        public double Perimetro()
        {
            return 2 * Math.PI *radio;
        }
    }
}