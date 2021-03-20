using System;

namespace Std
{
    class Principal
    {
        public static void Main(string[] args)
        {
            int AnoAtual,AnoDeNasc,i,IdadeDoUsuarioMaisNovo,IdadeDoUsuarioMaisVelho,Num;
            AnoDeNasc = i = IdadeDoUsuarioMaisNovo = IdadeDoUsuarioMaisVelho = 0;
            Num = 7;
            AnoAtual = DateTime.Now.Year;

            Console.WriteLine("\n                               O USUÁRIO MAIS VELHO E O USUÁRIO MAIS NOVO\n");

            while(i <= Num)
            {
                do
                {
                    Console.Write("\nDigite o ano de nascimento do usuário: ");
                    AnoDeNasc = short.Parse(Console.ReadLine());

                    if(AnoDeNasc < 1885 || AnoDeNasc > AnoAtual)
                    {
                        Console.WriteLine("\n       Answer not valid :(\n\n");
                    }
                }
                while(AnoDeNasc < 1885 || AnoDeNasc > AnoAtual);

                if(i == 0)
                {
                    IdadeDoUsuarioMaisVelho = IdadeDoUsuarioMaisNovo = (AnoAtual-AnoDeNasc);
                }
                else{
                    if((AnoAtual-AnoDeNasc) > IdadeDoUsuarioMaisVelho)
                    {
                        IdadeDoUsuarioMaisVelho = (AnoAtual-AnoDeNasc);
                    }
                    else
                    {
                        if((AnoAtual-AnoDeNasc) < IdadeDoUsuarioMaisNovo)
                        {
                            IdadeDoUsuarioMaisNovo = (AnoAtual-AnoDeNasc);
                        }
                    }
                }
                i++;
            }
            Console.WriteLine("\n\n     O usuário mais velho tem {0} anos enquanto que o usuário mais novo tem {1} anos.\n\n",IdadeDoUsuarioMaisVelho,IdadeDoUsuarioMaisNovo);
        }
    }
}