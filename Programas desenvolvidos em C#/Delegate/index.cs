using System;

delegate double QntdMov(float m, float v);
delegate double Impulso(float F, short t);
delegate double Newton(float m, float a);
delegate double MRUV(float Vo, float a, short t);

namespace Std{

    class Calculos{

        public static double Q(float m, float v){
            if(m <= 0 || v < 0){
                throw new Exception("                          Error 404 :( ...");
            }
            else{
                return m*v;
            }
        }
        public static double I(float F, short t){
            if(F < 0 || t < 0){
                throw new Exception("                          Error 404 :( ...");
            }
            else{
                return F*t;
            }
        }
        public static double F(float m, float a){
            if(m <= 0 || a < 0){
                throw new Exception("                          Error 404 :( ...");
            }
            else{
                return m*a;
            }
        }
        public static double V(float Vo, float a, short t){
            if(Vo < 0 || a < 0 || t < 0){
                throw new Exception("                          Error 404 :( ...");
            }
            else{
                return Vo+(a*t);
            }
        }
    }
    class Homework{

        public static void Main(string[] args){

            double Info;

            QntdMov MQ = new QntdMov(Calculos.Q);

            try{
                Info = MQ(324.2f,16.8f);
                Console.WriteLine("\n                       QUANTIDADE DE MOVIMENTO\n\n- A quantidade de movimento do evento foi de {0} kg.m/s\n",Info.ToString("F"));
            }
            catch(Exception a){
                Console.WriteLine("\n\n{0}\n",a.Message);
            }
            finally{
                Console.WriteLine("\n=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n");
            }

            Impulso Ns = new Impulso(Calculos.I);

            try{
                Info = Ns(1684.2f,1);
                Console.WriteLine("\n                               IMPULSO\n\n- O impulso do evento foi de {0} N.s\n",Info.ToString("F"));
            }
            catch(Exception a){
                Console.WriteLine("\n\n{0}\n",a.Message);
            }
            finally{
                Console.WriteLine("\n-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_\n");
            }

            Newton N = new Newton(Calculos.F);

            try{
                Info = N(1425.5f,0.7f);
                Console.WriteLine("\n                           LEIS DE NEWTON\n\n- A força nesse evento foi de {0} N\n",Info.ToString("F"));
            }
            catch(Exception a){
                Console.WriteLine("\n\n{0}\n",a.Message);
            }
            finally{
                Console.WriteLine("\n*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-\n");
            }

            MRUV Ms = new MRUV(Calculos.V);

            try{
                Info = Ms(4.8f,0.8f,36);
                Console.WriteLine("\n                     VELOCIDADE FINAL(M.R.U.V.)\n\n- A velocidade final do veículo é de {0} m/s\n",Info.ToString("F"));
            }
            catch(Exception a){
                Console.WriteLine("\n\n{0}\n",a.Message);
            }
            finally{
                Console.WriteLine("\n                  Programa executado com sucesso!\n\n");
            }
        }
    }
}