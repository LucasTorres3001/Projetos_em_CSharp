using System;

namespace Std
{
    class Dados
    {
        static void Main(string[] args)
        {
            string Resposta,Sexo;
            Resposta=Sexo="";
            short AnoDeNasc,MenoresDeIdade,SexoFem,SexoMasc;
            AnoDeNasc=MenoresDeIdade=SexoFem=SexoMasc=0;
            int AnoAtual;
            AnoAtual=DateTime.Now.Year;

            do
            {
                do
                {
                    Console.Write("\nDigite o ano de nascimento do usuário: ");
                    AnoDeNasc = short.Parse(Console.ReadLine());

                    if(AnoDeNasc < (AnoAtual-127) || AnoDeNasc > AnoAtual)
                    {
                        Console.WriteLine("\n   [Error] Year of birth invalid! :(\n");
                    }
                }
                while(AnoDeNasc < (AnoAtual-127) || AnoDeNasc > AnoAtual);

                if((AnoAtual-AnoDeNasc) < 18)
                {
                    MenoresDeIdade++;
                }

                do
                {
                    Console.Write("\nDigite o sexo do usuário(a) [Masc./Fem.]: ");
                    Sexo = Console.ReadLine();
                    
                    if(((Sexo!="f" && Sexo!="F") && (Sexo!="Feminino" && Sexo!="feminino" && Sexo!="FEMININO")) && ((Sexo!="m" && Sexo!="M") && (Sexo!="Masculino" && Sexo!="masculino" && Sexo!="MASCULINO")))
                    {
                        Console.WriteLine("\n   Sex of User invalid! :(\n");
                    }
                }
                while(((Sexo!="f" && Sexo!="F") && (Sexo!="Feminino" && Sexo!="feminino" && Sexo!="FEMININO")) && ((Sexo!="m" && Sexo!="M" && Sexo!="Masculino" && Sexo!="masculino" && Sexo!="MASCULINO")));

                if((Sexo=="m" || Sexo=="M") || (Sexo=="Masculino" || Sexo=="masculino" || Sexo=="MASCULINO"))
                {
                    SexoMasc++;
                }
                else
                {
                    if(((Sexo=="f" || Sexo=="F") || (Sexo=="Feminino" || Sexo=="feminino" || Sexo=="FEMININO")) && ((AnoAtual-AnoDeNasc) < 20))
                    {
                        SexoFem++;
                    }
                }
                Console.WriteLine("\n________________________________________________________________________________________________\n");
                do
                {
                    Console.WriteLine("Deseja continuar ? ");
                    Resposta = Console.ReadLine();

                    if(((Resposta!="n" && Resposta!="N") && (Resposta!="Nao" && Resposta!="nao" && Resposta!="NAO")) && ((Resposta!="s" && Resposta!="S") && (Resposta!="Sim" && Resposta!="sim" && Resposta!="SIM")))
                    {
                        Console.WriteLine("\n   Answer invalid! :(\n");
                    }
                }
                while(((Resposta!="n" && Resposta!="N") && (Resposta!="Nao" && Resposta!="nao" && Resposta!="NAO")) && ((Resposta!="s" && Resposta!="S") && (Resposta!="Sim" && Resposta!="sim" && Resposta!="SIM")));

                if((Resposta=="n" || Resposta=="N") || (Resposta=="nao" || Resposta=="NAO" || Resposta=="Nao"))
                {
                    break;
                }

                Console.WriteLine("\n________________________________________________________________________________________________\n");
            }
            while((Resposta=="s" || Resposta=="S") || (Resposta=="Sim" || Resposta=="sim" || Resposta=="SIM"));

            Console.WriteLine("\n\n - Em nosso cadastro, tivemos {0} usuário(s) cadastrado(s) menor(es) de idade, {1} usuário(s) do\nsexo masculino e {2} usuário(s) do sexo feminino menor(es) de 20 anos de idade.\n\n",MenoresDeIdade,SexoMasc,SexoFem);
        }
    }
}