using System;

namespace manipulação_de_texto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("informe um nome");
            var textoAntigo = Console.ReadLine();
            Console.WriteLine(textoAntigo.Replace(" ", ";"));


        }
    }
}
