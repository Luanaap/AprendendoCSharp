using System;

namespace _8_Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 8 - Condicionais2");

            int idadeJoao = 18;
            //int quantidadePessoas = 2;

            //bool acompanhado = quantidadePessoas >= 2;

            bool acompanhado = true;

            // || uma das condições podem ser satisfeitas pq é um OU 
            //&& as duas condições precisam ser satisfeitas
            if (idadeJoao >= 18 && acompanhado == true)
            {
                Console.WriteLine("Pode entrar");
            }
            else
            {

                Console.WriteLine("Não pode entrar");

            }

            Console.ReadLine();
        }
    }
}
