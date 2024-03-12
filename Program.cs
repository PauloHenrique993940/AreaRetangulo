using System;

namespace AreaRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double largura, altura;

            Console.WriteLine("Digite a largura do Retângulo: ");
            largura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura do Retângulo: ");
            altura = double.Parse(Console.ReadLine());

            double area = CalculoAreaRetangulo(largura, altura);
            double perimetro = CalcularPerimetro(largura, altura);
            double diagonal = CalculoDiagonal(largura, altura);

            Console.WriteLine("A área do retângulo é: {0:F2}", area);
            Console.WriteLine("O perímetro do retângulo é: {0:F2}", perimetro);
            Console.WriteLine("A diagonal do retângulo é: {0:F2}", diagonal);

            Console.ReadLine();
        }

        // Calcula a área do retângulo
        public static double CalculoAreaRetangulo(double largura, double altura)
        {
            return largura * altura;
        }

        // Calcula o perímetro do retângulo
        public static double CalcularPerimetro(double largura, double altura)
        {
            return 2 * (largura + altura);
        }

        // Calcula a diagonal do retângulo
        public static double CalculoDiagonal(double largura, double altura)
        {
            return Math.Sqrt((largura * largura) + (altura * altura));
        }
    }
}

