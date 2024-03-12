using System;

namespace AreaRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa Estrutural 
            // Obtendo dados da largura 
            Console.WriteLine("Digite a largura do Retângulo: ");
            double largura = double.Parse(Console.ReadLine());

            // Obtendo dados da altura
            Console.WriteLine("Digite a altura do Retângulo: ");
            double altura = double.Parse(Console.ReadLine());

            // Calculando área do Retângulo
            double area = largura * altura;

            // Calculando o perímetro
            double perimetro = 2 * (largura + altura);

            // Calculando a diagonal do retangulo
            double diagonal = Math.Sqrt((largura * largura) + (altura * altura));

            // Exibindo os resultados
            Console.WriteLine("A área do retângulo é: " + area);
            Console.WriteLine("O perímetro do retângulo é: " + perimetro);
            Console.WriteLine("A diagonal do retângulo é: " + diagonal);

            
            Console.ReadLine();

        }
    }
}
