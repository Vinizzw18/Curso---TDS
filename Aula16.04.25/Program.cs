using static System.Console;
using static System.Convert;
using System;

/*

namespace DataNascimento
{
    class CalcularIdade
    {
        public int Calcular(int AnoNascimento)
        {
            int resultado;
            if (AnoNascimento >= 2025)
            {
                WriteLine("\nIdade inválida (Maior ou igual que 2025)");
                return 0;
            }
            else if (AnoNascimento < 2025)
            {
                resultado = 2025 - AnoNascimento;
                return resultado;
                
            }
            else
            {
                WriteLine("Nascido em 2025!!");
            }
            return 0;
        }
        static void Main(string[] args)
        {
            CalcularIdade item = new CalcularIdade();
            WriteLine("Digite o Ano em que voce Nasceu: ");
            int numeroDig = Convert.ToInt32(ReadLine());
            WriteLine($"\nVocê tem {item.Calcular(numeroDig)} anos de idade!");
        }
    }
}

*/

//==================================================================================================================================================

using static System.Console;
using static System.Convert;
using System;



namespace menu
{
    class MenuClasse
    {
        public static void printMenu(String[] options)
        {
            foreach (String option in options)
            {
                WriteLine(option);
            }
            WriteLine("Escolha a sua opção: ");
        }

        public static void Main(string[] args)
        {
            WriteLine("==========MENU==========");
            String[] options = { "1 - Somar dois valores", "2 - Descobrir numero maior ", "3 - IMC", "4 - Sair" };
            int option = 0;
            while (true)
            {
                printMenu(options);
                try
                {
                    option = Convert.ToInt32(ReadLine());
                }
                catch (System.FormatException)
                {
                    WriteLine($"Por favor, digite uma opção entre 1 e {options.Length}");
                    continue;
                }
                catch (Exception)
                {
                    WriteLine("Aconteceu um erro fatal.");
                    continue;
                }
                switch (option)
                {
                    case 1:
                        option1();
                        break;
                    case 2:
                        option2();
                        break;
                    case 3:
                        option3();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        WriteLine($"Por favor, digite uma opção entre 1 e {options.Length}");
                        break;
                }
            }
        }

        private static void option3()
        {
            WriteLine("\nExecutando a opção 3...");
            WriteLine("\nDigite sua altura (em metros):");
            double n1 = ToDouble(ReadLine());
            WriteLine("Digite seu peso (em kg):");
            double n2 = ToDouble(ReadLine());
            WriteLine($"IMC: {n2 / (n1 * n1)}");

        }
        private static void option2()
        {
            WriteLine("\nExecutando a opção 2...");
            WriteLine("\nInsira 2 numeros: ");
            double numdig1 = ToDouble(ReadLine());
            double numdig2 = ToDouble(ReadLine());
            if (numdig1 > numdig2)
            {
                WriteLine($"\nO maior numero é: {numdig1}");
            }
            else if (numdig1 == numdig2)
            {
                WriteLine("\nOs numeros são iguais");
            }
            else
            {
                WriteLine($"\nO maior numero é: {numdig2}");
            }
        }
        private static void option1()
        {
            WriteLine("\nExecutando a opção 1...");
            WriteLine("\nInsira 2 numeros: ");
            double num1 = ToDouble(ReadLine());
            double num2 = ToDouble(ReadLine());
            double result1 = num1 + num2;
            WriteLine($"A soma de {num1} + {num2} = {result1}");
        }
    }
}
