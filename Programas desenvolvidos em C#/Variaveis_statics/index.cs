using System;

namespace Std{

    class Cinematica{

        public static double MRUV(float Vo, float a, short t){
            return Vo+(a*t);
        }
        public static double MU(float So, float V, short t){
            return So+(V*t);
        }
    }
    class Principal{

        public static void Main(string[] args){

            double V = Cinematica.MRUV(16.4f,1.2f,64);
            double S = Cinematica.MU(121.1f,14.8f,49);

            Console.WriteLine("\n                   Movimento Retílineo Uniformemente Váriado(M.R.U.V.)\n\nA velocidade final do veículo é de {0} m/s\n",V.ToString("F"));
            Console.WriteLine("\n-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_\n");
            Console.WriteLine("\n                               Movimento Uniforme(M.U.)\n\nA posição final do veículo é de {0} m.\n\n",S.ToString("F"));
        }
    }
}