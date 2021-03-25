using System;

delegate double MRUV(double x, float y, short z);

namespace Std{

    class Classe_Qualquer{

        public static double Nao_Sei(double x, float y, short z){
            return x+(y*z);
        }
        public static double Variavel(double a, double b, short c, float d){
            return a+(b*c)+((d*(c*c))/2);
        }
    }
    class Home{

        public static void Main(string[] args){

            double S,So,Vo;
            float a;
            short t;

            Console.WriteLine("\n               Movimento Retilineo Uniformemente Variado(M.R.U.V.)\n");
            do{
                Console.Write("\nDigite a posição inicial do veículo: ");
                So = double.Parse(Console.ReadLine());

                if(So < 0){
                    Console.WriteLine("\n       Value of space begin not valid :( ...\n\n");
                }
            }
            while(So < 0);
            do{
                Console.Write("\nDigite a velocidade inicial do veículo: ");
                Vo = double.Parse(Console.ReadLine());

                if(Vo < 0){
                    Console.WriteLine("\n       Value of the velocity not valid :( ...\n\n");
                }
            }
            while(Vo < 0);

            Console.Write("\nDigite a aceleração do veículo: ");
            a = float.Parse(Console.ReadLine());
            do{
                Console.Write("\nDigite o tempo de duração da viagem: ");
                t = short.Parse(Console.ReadLine());

                if(t < 0){
                    Console.WriteLine("\n       Value of time not valid :( ...\n\n");
                }
            }
            while(t < 0);

            Console.Clear();

            S = Classe_Qualquer.Variavel(So,Vo,t,a);

            Console.WriteLine("\n                               DADOS\n\n");
            Console.WriteLine("Posição inicial_____ {0} m.\n",So);
            Console.WriteLine("Velocidade inicial__ {0} m/s.\n",Vo);
            Console.WriteLine("Aceleração__________ {0} m/s².\n",a);
            Console.WriteLine("Tempo_______________ {0} s.\n",t);
            Console.WriteLine("Posição final_______ {0} m.\n",S.ToString("F"));

            double V=0;

            MRUV Velocity = new MRUV(Classe_Qualquer.Nao_Sei);

            V = Velocity(Vo,a,t);

            Console.WriteLine("\n-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_\n");
            Console.WriteLine("\n                               DADOS\n\n");
            Console.WriteLine("Velocidade inicial__ {0} m/s.\n",Vo);
            Console.WriteLine("Acelerção___________ {0} m/s².\n",a);
            Console.WriteLine("Tempo_______________ {0} s.\n",t);
            Console.WriteLine("Velocidade final____ {0} m/s.\n\n",V.ToString("F"));
        }
    }
}