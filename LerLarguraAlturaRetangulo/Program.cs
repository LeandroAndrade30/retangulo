using System;

namespace LerLarguraAlturaRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo Retangulo = new Retangulo();
            Console.WriteLine("Informe a largura do Retângulo");
            Retangulo.Largura = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a altura do Retângulo");
            Retangulo.Altura = double.Parse(Console.ReadLine());
            double AreaRetangulo= Retangulo.CalcularArea(Retangulo);
            Console.WriteLine($"A Area do retângulo é: {AreaRetangulo}");
            double Perimetro = Retangulo.CalcularPerimetro(Retangulo);
            Console.WriteLine($"O  Perimetro do retângulo é: {Perimetro}");
            double Diagonal = Retangulo.CalcularDiagonal(Retangulo);
            Console.WriteLine($"A  Diagonal do retângulo é: {Diagonal.ToString("F2")}");




        }
    }
}
