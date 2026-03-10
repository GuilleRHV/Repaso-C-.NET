using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FigurasPatterns
{
    public class Cuadrado : IFigura
    {
        private int _lado = 2;
        public int lado
        {
            get => _lado;
            set
            {
                _lado = value;
            }
        }

        public double Area()
        {
            return lado* lado;
        }

        public double Perimetro()
        {
            return lado * 4;
        }
    }
}