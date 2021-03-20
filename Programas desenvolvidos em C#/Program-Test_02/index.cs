using System;

namespace Std
{
    class Principal
    {
        public static void Main(string[] args)
        {
            short i,Numero,NumeroImpar,NumeroPar,SomaDosNumerosImpares,SomaDosNumerosPares;
            NumeroPar = NumeroImpar = SomaDosNumerosImpares = SomaDosNumerosPares = 0;

            Console.Clear();

            Console.Write("\n                               SOMA DOS NÚMEROS PARES E ÍMPARES\n");

            for(i=1; i <= 7; i++)
            {
                Console.Write("\nDigite o {0}º número: ",i);
                Numero = short.Parse(Console.ReadLine());

                if(Numero % 2 == 0)
                {
                    SomaDosNumerosPares+=Numero;
                    NumeroPar++;
                }
                else
                {
                    if(Numero % 2 != 0)
                    {
                        SomaDosNumerosImpares+=Numero;
                        NumeroImpar++;
                    }
                }
            }
            Console.WriteLine("\n-   O usuário digitou {0} número(s) PAR(ES) e {1} número(s) ÍMPAR(ES)!\n",NumeroPar,NumeroImpar);
            Console.WriteLine("-    A soma dos números pares deu {0} e a soma dos números ímpares deu {1}!\n",SomaDosNumerosPares,SomaDosNumerosImpares);

            if(SomaDosNumerosPares > SomaDosNumerosImpares)
            {
                Console.WriteLine("-    O maior valor foi a soma dos números PARES!\n");
            }
            else if(SomaDosNumerosImpares == SomaDosNumerosPares)
            {
                Console.WriteLine("-    Os dois valores são iguais!\n");
            }
            else
            {
                if(SomaDosNumerosImpares > SomaDosNumerosPares)
                {
                    Console.WriteLine("-    O maior valor foi a soma dos números ÍMPARES!\n");
                }
            }
        }
    }
}