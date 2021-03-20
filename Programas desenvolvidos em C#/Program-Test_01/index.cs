using System;

delegate int Name(int a, int b);

namespace Std{

    class Mat{

        public static int Adicao(int a, int b){
            return a+b;
        }
    }
    class MU{

        public static double Velocidade(float S, float So, short t){
            return (S-So)/t;
        }
    }
    class Velocidade{

        private short V;

        public short Kmh{
            get{
                return V;
            }
            set{
                if(value <= 0){
                    V=0;
                }
                else if(value > 0 && value < 385){
                    V=value;
                }
                else{
                    if(value > 385){
                        V=385;
                    }
                }
            }
        }
        public Velocidade(){
            Kmh=377;
        }
        public void Info(){
            Console.WriteLine("\n                             Métodos GET e SET\n\n- A velocidade do veículo é de {0} m/s.\n\n",Kmh);
        }
    }
    class Principal{

        public static void Main(string[] args){
/*------------------------------------------------------------- DELEGATES --------------------------------------------------------------*/
            int Dados;

            Name Calc = new Name(Mat.Adicao);

            Dados = Calc(841,784);
            Console.WriteLine("\n                                  DELEGATE\n\n- A soma deu {0}\n",Dados);
            Console.WriteLine("\n=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n");
/*--------------------------------------------------------- Variaveis STATICS ----------------------------------------------------------*/
            double V;

            V = MU.Velocidade(4096.4f,256.2f,169);

            Console.WriteLine("\n                          Variáveis do tipo STATICS\n\n- A velocidade média do veículo é de {0} m/s.\n",V.ToString("F"));
            Console.WriteLine("\n-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_\n");
/*--------------------------------------------------------- Métodos GET e SET ----------------------------------------------------------*/
            Velocidade Auto = new Velocidade();

            Auto.Info();
            
        }
    }
}