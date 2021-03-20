using System;

namespace Std{

    class Auto{

        private short kmh;

        public short Velocidade{
            get{
                return kmh;
            }
            set{
                if(value < 0){
                    kmh=0;
                }
                else if(value >=0 || value < 361){
                    kmh=value;
                }
                else{
                    if(value > 361){
                        kmh=361;
                    }
                }
            }
        }
        public Auto(){
            Velocidade=325;
        }
        public void Info(){
            Console.WriteLine("\n                               VELOCIDADE\n\nA velocidade do veículo é de {0} km/h.\n\n",Velocidade);
        }
    }
    class Principal{

        public static void Main(string[] args){
            
            Auto automovel = new Auto();

            automovel.Info();
        }
    }
}