using System;

namespace Std
{
    class Principal
    {
        public static void Main(string[] args)
        {
            int AnoAtual;
            short AnoDeNasc;
            AnoAtual = DateTime.Now.Year;
            string RespostaDoUser="";

            do
            {
                Console.Clear();

                Console.WriteLine("                                     ALISTAMENTO NO EXÉRCITO\n");

                Console.Write("Digite a ano de nascimento do usuário : ");
                AnoDeNasc = short.Parse(Console.ReadLine());

                if(AnoDeNasc > AnoAtual || AnoDeNasc < (AnoAtual - 125))
                {
                    Console.WriteLine("\n   [Error] Year of birth invalid!\n");
                }
                else
                {
                    if((AnoAtual-AnoDeNasc) >= 0 && (AnoAtual-AnoDeNasc) < 18)
                    {
                        Console.WriteLine("\n-  O usuário ainda não tem idade para o alistamento. Ele só poderá comparecer na junta militar\nno ano de {0} ... Ainda lhe falta(m) {1} ano(s) para o seu alistamento.\n",(AnoDeNasc + 18),(18 - (AnoAtual - AnoDeNasc)));
                    }
                    else if((AnoAtual-AnoDeNasc) == 18)
                    {
                        Console.WriteLine("\n-  O usuário já pode ir se alistar!\n");
                    }
                    else
                    {
                        if((AnoAtual-AnoDeNasc) > 18)
                        {
                            Console.WriteLine("\n-  O usuário passou da época do alistamento. Ele teria que ter comparecido na junta militar\nno ano de {0} ... Já se passaram {1} ano(s) para o alistamento.\n",(AnoDeNasc + 18),((AnoAtual - AnoDeNasc) - 18));
                        }
                    }
                }
                do
                {
                    Console.WriteLine("\nDeseja continuar ? ");
                    RespostaDoUser = Console.ReadLine();

                    if(((RespostaDoUser!="n" && RespostaDoUser!="N") && (RespostaDoUser!="nao" && RespostaDoUser!="Nao" && RespostaDoUser!="NAO")) && ((RespostaDoUser!="s" && RespostaDoUser!="S") && (RespostaDoUser!="sim" && RespostaDoUser!="Sim" && RespostaDoUser!="SIM")))
                    {
                        Console.Write("\nResposta inválida!\n");
                    }
                }
                while(((RespostaDoUser!="n" && RespostaDoUser!="N") && (RespostaDoUser!="nao" && RespostaDoUser!="Nao" && RespostaDoUser!="NAO")) && ((RespostaDoUser!="s" && RespostaDoUser!="S") && (RespostaDoUser!="sim" && RespostaDoUser!="Sim" && RespostaDoUser!="SIM")));

                if((RespostaDoUser=="n" || RespostaDoUser=="N") || (RespostaDoUser=="nao" || RespostaDoUser=="NAO" || RespostaDoUser=="Nao"))
                {
                    break;
                }
            }
            while((RespostaDoUser=="s" || RespostaDoUser=="S") || (RespostaDoUser=="sim" || RespostaDoUser=="SIM" || RespostaDoUser=="Sim"));

            Console.WriteLine("\n           Programa executado com sucesso! ;)...\n\n");
        }
    }
}