using System;

namespace AreaRetangulo
{
    public class AreaRetangulo
    {
        // Propriedades do retângulo
        private double Largura { get; }
        private double Altura { get; }

        // Construtor
        public AreaRetangulo(double largura, double altura)
        {
            Largura = largura;
            Altura = altura;
        }

        // Método para calcular a área
        public double CalcularArea()
        {
            return Largura * Altura;
        }

        // Método para calcular o perímetro
        public double CalcularPerimetro()
        {
            return 2 * (Largura + Altura);
        }

        // Método para calcular a diagonal
        public double CalcularDiagonal()
        {
            return Math.Sqrt((Largura * Largura) + (Altura * Altura));
        }
    }
}



    
