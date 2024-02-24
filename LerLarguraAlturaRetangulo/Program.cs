using System;

namespace LerLarguraAlturaRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a largura do Retângulo");
            double Largura = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a altura do Retângulo");
            double Altura = double.Parse(Console.ReadLine());
            double Area = (Largura * Altura);
            Console.WriteLine($"A Area do retângulo é: {Area}");
            double Perimetro = 2 * (Largura + Altura);
            Console.WriteLine($"O  Perimetro do retângulo é: {Perimetro}");
            double Diagonal = Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
            Console.WriteLine($"A  Diagonal do retângulo é: {Diagonal.ToString("F2")}");




        }
    }
}
