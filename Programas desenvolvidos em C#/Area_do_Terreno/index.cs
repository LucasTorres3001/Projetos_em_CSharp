using System;

namespace Std{

    class Terreno{

        public static double Area(double w, double l){
            if(w <= 0 || l <= 0){
                throw new Exception("                       Error 404 :( ...");
            }
            else{
                return w*l;
            }
        }
    }
    class Principal{

        public static void Main(string[] args){

            double A;

            A=0;

            try{
                A = Terreno.Area(16.44,25.55);
                Console.WriteLine("\n                       ÁREA DO TERRENO\n\n- A área do terreno é de {0} m²\n\n",A.ToString("F"));
            }
            catch(Exception a){
                Console.WriteLine("\n\n{0}\n",a.Message);
            }
            finally{
                Console.WriteLine("\n               Programa executado com sucesso!\n\n");
            }
        }
    }
}