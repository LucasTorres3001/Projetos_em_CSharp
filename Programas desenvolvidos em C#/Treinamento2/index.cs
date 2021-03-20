using System;

namespace Std{

    class Battery{

        private short Carregamento;
        
        public short Porcentagem{
            get{
                return Carregamento;
            }
            set{
                if(value <= 0){
                    Carregamento=0;
                }
                else if(value > 0 && value < 100){
                    Carregamento=value;
                }
                else{
                    if(value > 100){
                        Carregamento=100;
                    }
                }
            }
        }
        public Battery(){
            Porcentagem=64;
        }
        public void Info(){
            Console.WriteLine("\n                          CARREGAMENTO DA BATERIA\n\nA carga da bateria está em {0} %.\n\n",Porcentagem);
        }
    }
    class Principal{

        public static void Main(string[] args){

            Battery Carga = new Battery();

            Carga.Info();
        }
    }
}