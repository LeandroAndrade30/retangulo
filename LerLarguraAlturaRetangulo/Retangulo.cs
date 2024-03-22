using System;
using System.Collections.Generic;
using System.Text;

namespace LerLarguraAlturaRetangulo
{
    class Retangulo
    {
        public  double Largura;
        public  double Altura;

        public Retangulo (double largura, double altura)
        {
            Largura = largura;
            Altura = altura;
        }

        public  double CalcularArea()
        {
            double Area = (Largura * Altura);
            return Area;
        }

        public  double CalcularPerimetro()
        {
            double Perimetro = 2 * (Largura + Altura);
            return Perimetro;
        }

        public  double CalcularDiagonal()
        {
            double Diagonal = Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
            return Diagonal;
        }
        public override string ToString()
        {
            string mensagem = $"Largura: {Largura}, Altura: {Altura}, Área: {CalcularArea()}, Perímetro: {CalcularPerimetro()}, Diagonal: {CalcularDiagonal():F2}";
            return mensagem;

        }

    }
}

    


