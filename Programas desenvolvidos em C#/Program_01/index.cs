using System;

namespace Std
{
    class Program
    {
        public static void Main(string[] args)
        {
            string Resp="";
            int NumeroAleatorio;
            short Ganhou,Numero,Numero2,NumeroDeJogadas,Perdeu;
            Ganhou=Numero=Numero2=NumeroDeJogadas=Perdeu=0;

            do{

                NumeroDeJogadas++;

                Console.Clear();

                Console.WriteLine("\n------------------------------------------------ * GAME: Par ou Ímpar * ------------------------------------------------\n");

                do{
                    Console.Write("\nDigite o número 0 para ÍMPAR ou número 1 para PAR: ");
                    Numero = short.Parse(Console.ReadLine());

                    if(Numero < 0 || Numero > 1){
                        Console.WriteLine("\n   [ERROR] Number invalid! :(\n");
                    }
                }
                while(Numero < 0 || Numero > 1);

                do{
                    Console.Write("\nDigite um número qualquer: ");
                    Numero2 = short.Parse(Console.ReadLine());

                    if(Numero2 < 0 || Numero2 > 1000){
                        Console.WriteLine("\n   Error 404 :(\n");
                    }
                }
                while(Numero2 < 0 || Numero2 > 1000);

                Random Num = new Random();
                NumeroAleatorio = Num.Next(0,1000);
                
                if(Numero == 0)
                { //----------------------------------------------------- * ÍMPAR * -----------------------------------------------------
                    if((Numero2 + NumeroAleatorio) % 2 == 0)
                    { // Perdeu
                        Console.WriteLine("\n O resultado deu PAR!\n\n      O usuário jogou o número {0} e o P.C. jogou o número {1}\n\n  O usuário PERDEU! :(\n",Numero2,NumeroAleatorio);
                        Perdeu++;
                    }
                    else
                    {
                        if((Numero2 + NumeroAleatorio) % 2 != 0)
                        { // Venceu
                            Console.WriteLine("\n O resultado deu ÍMPAR!\n\n      O usuário jogou o número {0} e o P.C. jogou o número {1}\n\n  PARABÉNS! ... O usuário VENCEU! ;)\n",Numero2,NumeroAleatorio);
                            Ganhou++;
                        }
                    }
                }
                else
                {
                    if(Numero == 1)
                    { //---------------------------------------------------- * PAR * ----------------------------------------------------
                        if((Numero2 + NumeroAleatorio) % 2 == 0)
                        { // Venceu
                            Console.WriteLine("\n O resultado deu PAR!\n\n      O usuário jogou o número {0} e o P.C. jogou o número {1}\n\n  PARABÉNS! ... O usuário VENCEU! ;)\n",Numero2,NumeroAleatorio);
                            Ganhou++;
                        }
                        else
                        {
                            if((Numero2 + NumeroAleatorio) % 2 != 0)
                            { // Perdeu
                                Console.WriteLine("\n O resultado deu ÍMPAR!\n\n      O usuário jogou o número {0} e o P.C. jogou o número {1}\n\n  O usuário PERDEU! :(\n",Numero2,NumeroAleatorio);
                                Perdeu++;
                            }
                        }
                        
                    }
                }
                Console.WriteLine("\n-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_\n");
                do
                {
                    Console.Write("\nDeseja constinuar ? ");
                    Resp = Console.ReadLine();

                    if(((Resp!="s" && Resp!="S") && (Resp!="sim" && Resp!="SIM" && Resp!="Sim")) && ((Resp!="n" && Resp!="N") && (Resp!="nao" && Resp!="NAO" && Resp!="Nao")))
                    {
                        Console.WriteLine("\n   Answer invalid! :(\n");
                    }
                }
                while(((Resp!="s" && Resp!="S") && (Resp!="sim" && Resp!="SIM" && Resp!="Sim")) && ((Resp!="n" && Resp!="N") && (Resp!="nao" && Resp!="NAO" && Resp!="Nao")));

                if((Resp=="n" || Resp=="N") || (Resp=="nao" || Resp=="NAO" || Resp=="Nao"))
                {
                    break;
                }
            }
            while((Resp=="s" || Resp=="S") || (Resp=="sim" || Resp=="SIM" || Resp=="Sim"));

            Console.WriteLine("\n      O usuário jogou {0} vez(es), ganhou {1} vez(es) e perdeu {2} vez(es).",NumeroDeJogadas,Ganhou,Perdeu);
            Console.WriteLine("\n      O usuário fez no total: {0} pontos.\n\n",(Ganhou*3));
        }
    }
}