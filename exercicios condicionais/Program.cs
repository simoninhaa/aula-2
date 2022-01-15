using System;

namespace exercicios_condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("escreva idade");
            var idade = Console.ReadLine();
            var numero = Convert.ToInt32(idade);

            if (numero >= 13 && numero < 19)
            {
                Console.WriteLine("adolescente");
            }
            else if (numero >= 19 && numero <= 60)

            {
                Console.WriteLine("Adulto");
            }
            else if (numero > 60)
            {
                Console.WriteLine("Idoso");
            }
            else
            {
                Console.WriteLine("criança");
            }
            Console.ReadKey();
            }
        }
    }
