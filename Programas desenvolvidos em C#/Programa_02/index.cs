using System;

namespace Std
{
    class None
    {
        public static void Main(string[] args)
        {
            short Numero,QntdDeNumerosDigitados;
            Numero = QntdDeNumerosDigitados = 0;

            Console.Clear();

            Console.Write("                                     PROGRAMA!\n");

            while(Numero != 999)
            {
                Console.Write("\nDigite um número de forma aleatória: ");
                Numero = short.Parse(Console.ReadLine());

                QntdDeNumerosDigitados++;
            }

            Console.WriteLine("\n-  Saindo ...\n");
            Console.WriteLine("\n-  O usuário digitou {0} número(s)!\n",(QntdDeNumerosDigitados-1));
        }
    }
}