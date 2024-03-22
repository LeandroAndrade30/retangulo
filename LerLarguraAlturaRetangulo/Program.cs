using System;

namespace LerLarguraAlturaRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Informe a largura do Retângulo");
             double largura = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a altura do Retângulo");
             double altura = double.Parse(Console.ReadLine());
            Retangulo Retangulo = new Retangulo(largura,altura);
            Console.WriteLine(Retangulo);
        




        }
    }
}
