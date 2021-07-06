using System;

namespace P13_ForEncadeado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Projeto 13 - For Encadeado!");

            //Escrevendo asteriscos com o BREAK
            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for(int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
                {
                    Console.Write("*");
                    if (contadorColuna >= contadorLinha)
                        break;
                }

                Console.WriteLine();
            }

            // Uma forma diferente de fazer o desenho de asteriscos
            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna <= contadorLinha; contadorColuna++)

                    Console.Write("*");                   


                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
