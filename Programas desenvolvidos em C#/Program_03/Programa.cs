using System;

namespace Std
{
    class Principal
    {
        public static void Main(string[] args)
        {
            short i,IdadeDoUsuario,UsuarioMaisNovo,UsuarioMaisVelho;
            UsuarioMaisNovo = UsuarioMaisVelho = 0;

            Console.WriteLine("\n                           O USUÁRIO MAIS VELHO E O USUÁRIO MAIS NOVO\n");

            for(i=1; i <= 7; i++)
            {
                do
                {
                    Console.Write("\nDigite a idade do {0}º usuário: ",i);
                    IdadeDoUsuario = short.Parse(Console.ReadLine());

                    if(IdadeDoUsuario < 0 || IdadeDoUsuario > 125)
                    {
                        Console.WriteLine("\n   [Error] Age not valid! :(\n\n");
                    }
                }
                while(IdadeDoUsuario < 0 || IdadeDoUsuario > 125);

                if(i == 1)
                {
                    UsuarioMaisNovo = UsuarioMaisVelho = IdadeDoUsuario;
                }
                else
                {
                    if(IdadeDoUsuario > UsuarioMaisVelho)
                    {
                        UsuarioMaisVelho = IdadeDoUsuario;
                    }
                    else{
                        if(IdadeDoUsuario < UsuarioMaisNovo)
                        {
                            UsuarioMaisNovo = IdadeDoUsuario;
                        }
                    }
                }
            }
            Console.WriteLine("\n\n     O usuário mais velho tem {0} anos e o usuário mais novo tem {1} anos.\n\n",UsuarioMaisVelho,UsuarioMaisNovo);
        }
    }
}