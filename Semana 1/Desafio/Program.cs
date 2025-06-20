using System;

namespace MyApplication
{
  class Program
  {
        static void Main(string[] args)
        {
            // Type your username and press enter
            Console.WriteLine("Escolha uma função (+, -, *, /):");

            // Create a string variable and get user input from the keyboard and store it in the variable
            string funcao = Console.ReadLine();

            if (funcao != "+" && funcao != "-" && funcao != "*" && funcao != "/")
            {
                Console.WriteLine("Função inválida. Por favor, escolha entre +, -, *, /.");
                return;
            }
            
            // Create a double variable and get user input from the keyboard and store it in the variable
            Console.WriteLine("Digite o primeiro número:");

            // Read the input from the user and convert it to a double
            double num1 = Convert.ToDouble(Console.ReadLine());

            // Read the second number from the user
            Console.WriteLine("Digite o segundo número:");

            // Read the input from the user and convert it to a double
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (funcao == "+")
            {
                double resultado = num1 + num2;
                Console.WriteLine($"Resultado: {resultado}");
            }
            else if (funcao == "-")
            {
                double resultado = num1 - num2;
                Console.WriteLine($"Resultado: {resultado}");
            }
            else if (funcao == "*")
            {
                double resultado = num1 * num2;
                Console.WriteLine($"Resultado: {resultado}");
            }
            else if (funcao == "/")
            {
                if (num2 != 0)
                {
                    double resultado = num1 / num2;
                    Console.WriteLine($"Resultado: {resultado}");
                }
                else
                {
                    Console.WriteLine("Erro: Divisão por zero não é permitida.");
                }
            }
            else
            {
                Console.WriteLine("Função inválida. Por favor, escolha entre +, -, *, /.");
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Número atual: {i + 1}");
            }
    }
  }
}