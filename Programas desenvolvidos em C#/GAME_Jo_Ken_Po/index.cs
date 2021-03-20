using System;

namespace Std
{
    class Principal
    {
        public static void Main(string[] args)
        {
            string[] Opcao = {"Papel","Pedra","Tesoura"};
            string Resp="";
            int NumeroAleatorio;
            byte OpcaoDoUsuario,NumeroDeVezesJogadas,NumeroDeDerrotas,NumeroDeEmpates,NumeroDeVitorias;
            NumeroDeVezesJogadas=NumeroDeDerrotas=NumeroDeEmpates=NumeroDeVitorias=0;

            do
            {
                Random Numero = new Random();
                NumeroAleatorio = Numero.Next(0,3);
                
                Console.Clear();

                Console.WriteLine("\n                               GAME: Jo-Ken-Po!\n");

                Console.Write("\nSelecione uma opção:\n\n0) Papel   1) Pedra    2) Tesoura\n\nO usuário jogará: ");
                OpcaoDoUsuario = byte.Parse(Console.ReadLine());

                Console.WriteLine("\n--------------------------------\n");

                if(OpcaoDoUsuario < 0 || OpcaoDoUsuario > 2)
                {
                    Console.WriteLine("\n     [Error] Option invalid! :(\n\n");
                }
                else
                {
                    if(OpcaoDoUsuario == 0)
                    { //-------------------------------------- * PAPEL * --------------------------------------
                        if(NumeroAleatorio == 0)
                        { //Papel
                            Console.WriteLine("\nEMPATOU!...\n\n   O usuário jogou {0} e o P.C. jogou {1}!\n\n",Opcao[OpcaoDoUsuario],Opcao[NumeroAleatorio]);
                            NumeroDeEmpates++;
                        }
                        else if(NumeroAleatorio == 1)
                        { //Pedra
                            Console.WriteLine("\nPARABÉNS! ;)... Você GANHOU de mim!\n\n   O usuário jogou {0} e o P.C. jogou {1}!\n\n",Opcao[OpcaoDoUsuario],Opcao[NumeroAleatorio]);
                            NumeroDeVitorias++;
                        }
                        else
                        {
                            if(NumeroAleatorio == 2)
                            { //Tesoura
                                Console.WriteLine("\nGANHEI! :)... Infelizmente, não foi dessa vez!\n\n    O usuário jogou {0} e o P.C. jogou {1}!\n\n",Opcao[OpcaoDoUsuario],Opcao[NumeroAleatorio]);
                                NumeroDeDerrotas++;
                            }
                        }
                    }
                    else if(OpcaoDoUsuario == 1)
                    { //-------------------------------------- * PEDRA * --------------------------------------
                        if(NumeroAleatorio == 0)
                        { //Papel
                            Console.WriteLine("\nGANHEI! :)... Infelizmente, não foi dessa vez!\n\n    O usuário jogou {0} e o P.C. jogou {1}!\n\n",Opcao[OpcaoDoUsuario],Opcao[NumeroAleatorio]);
                            NumeroDeDerrotas++;
                        }
                        else if(NumeroAleatorio == 1)
                        { //Pedra
                            Console.WriteLine("\nEMPATOU!...\n\n   O usuário jogou {0} e o P.C. jogou {1}!\n",Opcao[OpcaoDoUsuario],Opcao[NumeroAleatorio]);
                            NumeroDeEmpates++;
                        }
                        else
                        {
                            if(NumeroAleatorio == 2)
                            { //Tesoura
                                Console.WriteLine("\nPARABÉNS! ;)... Você GANHOU de mim!\n\n   O usuário jogou {0} e o P.C. jogou {1}!\n\n",Opcao[OpcaoDoUsuario],Opcao[NumeroAleatorio]);
                                NumeroDeVitorias++;
                            }
                        }
                    }
                    else
                    {
                        if(OpcaoDoUsuario == 2)
                        { //-------------------------------------- * TESOURA * --------------------------------------
                            if(NumeroAleatorio == 0)
                            { //Papel
                                Console.WriteLine("\nPARABÉNS! ;)... Você GANHOU de mim!\n\n   O usuário jogou {0} e o P.C. jogou {1}!\n\n",Opcao[OpcaoDoUsuario],Opcao[NumeroAleatorio]);
                                NumeroDeVitorias++;
                            }
                            else if(NumeroAleatorio == 1)
                            { //Pedra
                                Console.WriteLine("\nGANHEI! :)... Infelizmente, não foi dessa vez!\n\n    O usuário jogou {0} e o P.C. jogou {1}!\n\n",Opcao[OpcaoDoUsuario],Opcao[NumeroAleatorio]);
                                NumeroDeDerrotas++;
                            }
                            else
                            {
                                if(NumeroAleatorio == 2)
                                { //Tesoura
                                    Console.WriteLine("\nEMPATOU!...\n\n   O usuário jogou {0} e o P.C. jogou {1}!\n\n",Opcao[OpcaoDoUsuario],Opcao[NumeroAleatorio]);
                                    NumeroDeEmpates++;
                                }
                            }
                        }
                    }
                }
                NumeroDeVezesJogadas++;
                do
                {
                    Console.WriteLine("\n_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-\n");

                    Console.WriteLine("\nDeseja continuar ? ");
                    Resp = Console.ReadLine();

                    if(((Resp!="n" && Resp!="N") && (Resp!="nao" && Resp!="NAO" && Resp!="Nao")) && ((Resp!="s" && Resp!="S") && (Resp!="sim" && Resp!="SIM" && Resp!="Sim")))
                    {
                        Console.WriteLine("\n      [Error] Answer invalid! :(\n");
                    }
                }
                while(((Resp!="n" && Resp!="N") && (Resp!="nao" && Resp!="NAO" && Resp!="Nao")) && ((Resp!="s" && Resp!="S") && (Resp!="sim" && Resp!="SIM" && Resp!="Sim")));

                if((Resp=="n" || Resp=="N") || (Resp=="nao" || Resp=="NAO" || Resp=="Nao"))
                {
                    break;
                }
            }
            while((Resp=="s" || Resp=="S") || (Resp=="sim" || Resp=="SIM" || Resp=="Sim"));

            Console.WriteLine("\n   O usuário jogou {0} partidas, ganhou {1}, empatou {2} e perdeu {3}.\n",NumeroDeVezesJogadas,NumeroDeVitorias,NumeroDeEmpates,NumeroDeDerrotas);
            Console.WriteLine("\n   O usuários fez ao todo: {0} pontos.\n\n\n",((NumeroDeVitorias*3)+NumeroDeEmpates));
        }
    }
}