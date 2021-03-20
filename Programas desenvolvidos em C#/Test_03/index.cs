using System;

namespace Std
{
    class Principal
    {
        public static void Main(string[] args)
        {
            Random NumeroAleatorio = new Random();
            int ValorInteiro = NumeroAleatorio.Next(0,10);
            string NomeDoUsuario="";
            byte Numero,ContadorDeLacos,SomaTotal;
            Numero = ContadorDeLacos = SomaTotal = 0;

            Console.Write("\nDigite o nome do usuário: ");
            NomeDoUsuario = Console.ReadLine();

            Console.WriteLine("\n\nOlá, {0}!\n\n  Eu sou o seu computador e estou pansando em um número.\nSerá que você vai conseguir adivinhar qual é o número ?\n",NomeDoUsuario);

            while(Numero != ValorInteiro)
            {
                Console.Write("\nDigite aqui um número qualquer: ");
                Numero = byte.Parse(Console.ReadLine());

                if(Numero < 0 || Numero > 10)
                {
                    Console.WriteLine("\n    Number nagative invalid! :(\n");
                }
                else
                {
                    if(Numero < ValorInteiro)
                    {
                        Console.WriteLine("\n   - O número em que eu estou pensando é MAIOR!\n\n");
                    }
                    else
                    {
                        if(Numero > ValorInteiro)
                        {
                            Console.WriteLine("\n   - O número em que eu estou pensando é MENOR!\n\n");
                        }
                    }
                }
                SomaTotal += Numero;
                ContadorDeLacos++;
            }
            Console.WriteLine("\n - PARABÉNS, agora você acertou! ;) ... Você precisou de {0} tentativas!",ContadorDeLacos);
            Console.WriteLine("\n - A soma dos números digitados foi igual a {0}\n\n",SomaTotal);
        }
    }
}