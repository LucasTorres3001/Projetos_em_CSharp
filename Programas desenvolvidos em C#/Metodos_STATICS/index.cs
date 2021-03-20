using System;

namespace Std{

    class MovUniforme{
        
        public static double Space(float So, float V, short t){
            return So+(V*t);
        }
        public static double Speed(float S, float So, short t){
            return (S-So)/t;
        }
    }
    class MRUV{

        public static double Velocy(float Vo, float a, short t){
            return Vo+(a*t);
        }
        public static double Acceleration(float V, float Vo, short t){
            return (V-Vo)/t;
        }
    }
    class Principal{

        public static void Main(string[] args){

            double S = MovUniforme.Space(121.1f,18.8f,64);
            double V1 = MovUniforme.Speed(2048.2f,64.8f,56);
            double V2 = MRUV.Velocy(8.4f,0.7f,35);
            double a = MRUV.Acceleration(19.8f,8.1f,49);

            Console.WriteLine("\n                          Espaço final(M.U.)\n\nA posição final do veículo é de {0} m.\n",S.ToString("F"));
            Console.WriteLine("\n=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n");
            Console.WriteLine("\n                        Velocidade média(M.U.)\n\nA velocidade média do veículo é de {0} m/s.\n",V1.ToString("F"));
            Console.WriteLine("\n-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_\n");
            Console.WriteLine("\n                       Velocidade final(M.R.U.V.)\n\nA velocidade final do veículo é de {0} m/s.\n",V2.ToString("F"));
            Console.WriteLine("\n=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n");
            Console.WriteLine("\n                         Aceleração(M.R.U.V.)\n\nA aceleração do veículo é de {0} m/s².\n\n",a.ToString("F"));
        }
    }
}