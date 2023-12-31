using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Multiplicacao();

        }
        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine("");
            float soma = v1 + v2;
            Console.WriteLine($"O resultado da soma é = {soma}");

        }
        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine("");
            float subtracao = v1 - v2;
            System.Console.WriteLine($"Resultado da subtração= {subtracao}");
            Console.ReadKey();

        }
        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine("");
            float divisao = v1 / v2;
            Console.WriteLine($"Resultado da divisão = {divisao}");


        }
        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine("");
            float multiplicacao = v1 * v2;
            Console.WriteLine($"A multicação é = {multiplicacao}");
        }
    }
}