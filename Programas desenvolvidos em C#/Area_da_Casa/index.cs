using System;

namespace Std{

    class Casa{

        public static double Calculo(double w, double l){
            if(w <= 0 || l <= 0){
                throw new Exception("                         Error 404 :( ...");
            }
            else{
                return w*l;
            }
        }
    }
    class Principal{

        public static void Main(string[] args){

            double Area;

            Area=0;

            try{
                Area = Casa.Calculo(0,10.25);
                Console.WriteLine("\n\nA casa tem uma área de {0} m².\n",Area.ToString("F"));
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