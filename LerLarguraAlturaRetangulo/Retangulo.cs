using System;
using System.Collections.Generic;
using System.Text;

namespace LerLarguraAlturaRetangulo
{
    class Retangulo
    {
        public static double Largura;
        public static double Altura;

        public static double CalcularArea(Retangulo Retangulo)
        {
            double Area = (Retangulo.Largura * Retangulo.Altura);
            return Area;
        }

        public static double CalcularPerimetro(Retangulo Retangulo)
        {
            double Perimetro = 2 * (Retangulo.Largura + Retangulo.Altura);
            return Perimetro;
        }

        public static double CalcularDiagonal(Retangulo Retangulo)
        {
            double Diagonal = Math.Sqrt(Math.Pow(Retangulo.Largura, 2) + Math.Pow(Retangulo.Altura, 2));
            return Diagonal;
        }

    }
}

    


