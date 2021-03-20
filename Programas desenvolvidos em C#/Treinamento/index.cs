using System;

namespace Std{

    class Fisica{

        public static double MRUV(float So, float Vo, short t, float a){
            return So+(Vo*t)+((a*(t*t))/2);
        }
        public static double Hidrostatica(float F, float A){
            return F/A;
        }
    }
    class Principal{

        public static void Main(string[] args){

            double S = Fisica.MRUV(81.9f,9.3f,49,1.1f);
            double P = Fisica.Hidrostatica(1600.4f,25.5f);

            Console.WriteLine("\n                       Mov. Retilineo Uniformemente Váriado(M.R.U.V.)\n\nA posição final do veículo é de {0} m.\n",S.ToString("F"));
            Console.WriteLine("\n_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-\n");
            Console.WriteLine("\n                                       HIDROSTÁTICA\n\nA presão no líquido é de {0} Pa.\n\n",P.ToString("F"));
        }
    }
}