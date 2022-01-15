using System;

namespace criptografia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo a aplicação de criptografia");
            Console.WriteLine("informe a senha");

            var senha = Console.ReadLine();
            var senhaCriptografada = "";
            var randon = new Random();
            for (int i = senha.Length; i >= 1; i--)
            {
                senhaCriptografada += senha[i - 1].ToString() + randon.Next(9);
            }
            Console.WriteLine(senhaCriptografada);
            Console.ReadKey();
        }
    }
}
