// See https://aka.ms/new-console-template for more information
using System;

namespace Desafio
{
    class Program
    {
        static void Somar(int a, int b)
        {
            int resultado = a + b;
            Console.WriteLine($"A soma dos números é: {resultado}");
        }

        static void ConversorTemperatura(int a)
        {
            int fahrenheit = (a * 9 / 5) + 32;
            Console.WriteLine($"A temperatura em Fahrenheit é: {fahrenheit}");
        }

        static void Main(string[] args)
        {
            Somar(3, 5);
            ConversorTemperatura(25);
        }
    }
}
