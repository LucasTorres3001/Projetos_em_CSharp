using System;

namespace Std
{
    class Principal
    {
        public static void Main(string[] args)
        {
            byte AlternativeOfUser;
            string RespDoUsuario;

            inicio:

            Console.Clear();

            Console.WriteLine("\n   Escolha apenas uma entre as seguinte alternativas abaixo:\n\n1) Alemanha   2) Itália   3) Canadá   4) Estados Unidos da América    5) Argentina    6) Uruguai\n");
            AlternativeOfUser = byte.Parse(Console.ReadLine());

            switch(AlternativeOfUser)
            {
                case 1:
                case 2:
                    Console.Write("EUROPA!\n\n");
                    switch(AlternativeOfUser)
                    {
                        case 1:
                            Console.Write("Você selecionou a Alemanha!\n");
                        break;
                        case 2:
                            Console.Write("Você selecionou a Itália!\n");
                        break;
                    }
                    break;
                case 3:
                case 4:
                    Console.Write("AMÉRICA DO NORTE!\n\n");
                    switch(AlternativeOfUser)
                    {
                        case 3:
                            Console.Write("Você selecionou o Canadá!\n");
                        break;
                        case 4:
                            Console.Write("Você selecionou os Estados Unidos da América!\n");
                        break;
                    }
                    break;
                case 5:
                case 6:
                    Console.Write("AMÉRICA DO SUL!\n\n");
                    switch(AlternativeOfUser)
                    {
                        case 5:
                            Console.Write("Você selecionou a Argentina!\n");
                        break;
                        case 6:
                            Console.Write("Você selecionou o Uruguai!\n");
                        break;
                    }
                    break;
                default:
                    Console.Write("Opção inválida!\n");
                break;
            }

            do
            {
                Console.Write("\nDeseja continuar [S/N]? ");
                RespDoUsuario = Console.ReadLine();

                if(((RespDoUsuario!="s" && RespDoUsuario!="S") && (RespDoUsuario!="sim" && RespDoUsuario!="SIM" && RespDoUsuario!="Sim")) && ((RespDoUsuario!="n" && RespDoUsuario!="N") && (RespDoUsuario!="nao" && RespDoUsuario!="NAO" && RespDoUsuario!="Nao")))
                {
                    Console.WriteLine("\n       Answer not valid :(\n\n");
                }
            }
            while(((RespDoUsuario!="s" && RespDoUsuario!="S") && (RespDoUsuario!="sim" && RespDoUsuario!="SIM" && RespDoUsuario!="Sim")) && ((RespDoUsuario!="n" && RespDoUsuario!="N") && (RespDoUsuario!="nao" && RespDoUsuario!="NAO" && RespDoUsuario!="Nao")));

            if((RespDoUsuario=="s" || RespDoUsuario=="S") || (RespDoUsuario=="sim" || RespDoUsuario=="SIM" || RespDoUsuario=="Sim"))
            {
                goto inicio;
            }
            else
            {
                if((RespDoUsuario=="n" || RespDoUsuario=="N") || (RespDoUsuario=="nao" || RespDoUsuario=="NAO" || RespDoUsuario=="Nao"))
                {
                    Console.Write("\n\n                         Fim do programa!\n\n");
                }
            }
        }
    }
}