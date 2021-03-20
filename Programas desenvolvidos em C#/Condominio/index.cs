using System;

namespace Std{

    class Principal{

        public static void Main(string[] args){

            string Resp="";
            short Moradores;
            double Calc1,Calc2,Contador,ValorDoCondominio,ValorDaMulta;
            Contador=Calc2=0;

            Console.WriteLine("\n                                       CONDOMINIO\n");

            do{
                Console.Write("\nQuantas pessoas residem no prédio? ");
                Moradores = short.Parse(Console.ReadLine());

                if(Moradores <= 0){
                    Console.WriteLine("\n       [ERROR] Number not valid :(\n\n");
                }
            }
            while(Moradores <= 0);
            do{
                do{
                    Console.Write("\nQual é o preço total do condominio ? R$ ");
                    ValorDoCondominio = double.Parse(Console.ReadLine());

                    if(ValorDoCondominio <= 0){
                        Console.WriteLine("\n       [ERROR] Value not valid :(\n\n");
                    }
                }
                while(ValorDoCondominio <= 0);
                do{
                    Console.Write("\nTem multa há ser paga? Sim/Não ? ");
                    Resp = Console.ReadLine();

                    if(((Resp!="s" && Resp!="S") && (Resp!="sim" && Resp!="SIM" && Resp!="Sim")) && ((Resp!="n" && Resp!="N") && (Resp!="nao" && Resp!="NAO" && Resp!="Nao"))){
                        Console.WriteLine("\n       [ERROR] Answer not valid :(\n\n");
                    }
                }
                while(((Resp!="s" && Resp!="S") && (Resp!="sim" && Resp!="SIM" && Resp!="Sim")) && ((Resp!="n" && Resp!="N") && (Resp!="nao" && Resp!="NAO" && Resp!="Nao")));

                if((Resp=="s" || Resp=="S") || (Resp=="sim" || Resp=="SIM" || Resp=="Sim")){
                    Console.Write("\nQual é o valor da multa ? R$ ");
                    ValorDaMulta = double.Parse(Console.ReadLine());

                    Calc1=(ValorDoCondominio+ValorDaMulta)/Moradores;

                    Console.WriteLine("\n\n          Cada morador terá que pagar um valor de R$ {0} reais.\n",Calc1);
                    Console.WriteLine("\n-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_\n");
                    Contador+=Calc1;
                }
                else{
                    if((Resp=="n" || Resp=="N") || (Resp=="nao" || Resp=="NAO" || Resp=="Nao")){

                        Calc2=ValorDoCondominio/Moradores;

                        Console.WriteLine("\n\n         Cada morador terá que pagar um valor de R$ {0} reais.\n",Calc2);
                        Console.WriteLine("\n-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_\n");
                        break;
                    }
                }
            }
            while((Resp=="s" || Resp=="S") || (Resp=="sim" || Resp=="SIM" || Resp=="Sim"));

            Console.WriteLine("\n\n     O valor total do condominio mais as multas ficou no valor de R$ {0} reais.\n\n",Contador+Calc2);
        }
    }
}