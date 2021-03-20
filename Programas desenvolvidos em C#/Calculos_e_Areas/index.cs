using System;

delegate double Casa(double width, double length);
delegate double Terreno(double w, double l);
delegate int Idade(int AnoAtual, short AnoDeNasc);
delegate double MU(float S, float V, short t);

namespace Std{

    class Calculos{

        public static double AreaDaCasa(double width, double length){
            if(width <= 0 || length <= 0){
                throw new Exception("                             Error 404 :( ...");
            }
            else{
                return width*length;
            }
        }
        public static double AreaDoTerreno(double w, double l){
            if(w <= 0 || l <= 0){
                throw new Exception("                             Error 404 :( ...");
            }
            else{
                return w*l;
            }
        }
        public static int IdadeDoUsuario(int AnoAtual, short AnoDeNasc){
            if(AnoDeNasc <= (AnoAtual-124) || AnoDeNasc > AnoAtual){
                throw new Exception("                             Error 404 :( ...");
            }
            else{
                return AnoAtual-AnoDeNasc;
            }
        }
        public static double Space(float So, float V, short t){
            if(So < 0 || V < 0 || t < 0){
                throw new Exception("                             Error 404 :( ...");
            }
            else{
                return So+(V*t);
            }
        }
/*--------------------------------------------------------- Métodos GET & SET ---------------------------------------------------------*/
        private int Hrs;

        public int Dia{
            get{
                return Hrs;
            }
            set{
                if(value <= 0){
                    Hrs=0;
                }
                else if(value > 0 && value < 23){
                    Hrs=value;
                }
                else{
                    if(value > 23){
                        Hrs=23;
                    }
                }
            }
        }
        public Calculos(){
            Dia=DateTime.Now.Hour;
        }
        public void Msg(){
            Console.WriteLine("\n                            HORÁRIO DO DIA\n\n- Horário: {0} h\n\n",Dia);
        }
    }
    class Home{

        public static void Main(string[] args){

            double Info;

            Casa Metro = new Casa(Calculos.AreaDaCasa);

            try{
                Info = Metro(16.28,25.55);
                Console.WriteLine("\n                                 CASA\n\n- A casa tem uma área de {0} m².\n",Info.ToString("F"));
            }
            catch(Exception a){
                Console.WriteLine("\n\n{0}\n",a.Message);
            }
            finally{
                Console.WriteLine("\n=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n");
            }

            Terreno Campo = new Terreno(Calculos.AreaDoTerreno);

            try{
                Info = Campo(105.06,67.96);
                Console.WriteLine("\n                                TERRENO\n\n- O terreno tem uma área de {0} m².\n",Info.ToString("F"));
            }
            catch(Exception a){
                Console.WriteLine("\n\n{0}\n",a.Message);
            }
            finally{
                Console.WriteLine("\n-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_\n");
            }

            Idade Usuario = new Idade(Calculos.IdadeDoUsuario);

            try{
                Info = Usuario(DateTime.Now.Year,2002);
                Console.WriteLine("\n                            IDADE DO USUÁRIO\n\n- O usuário tem {0} anos, atualmente.\n",Info);
            }
            catch(Exception a){
                Console.WriteLine("\n\n{0}\n",a.Message);
            }
            finally{
                Console.WriteLine("\n-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*\n");
            }

            MU S = new MU(Calculos.Space);

            try{
                Info = S(196.1f,16.8f,64);
                Console.WriteLine("\n                        MOVIMENTO UNIFORME(M.U.)\n\n- A posição final do veículo é {0} m.\n",Info.ToString("F"));
            }
            catch(Exception a){
                Console.WriteLine("\n\n{0}\n",a.Message);
            }
            finally{
                Console.WriteLine("\n*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_\n");
            }

            Calculos Hr = new Calculos();

            Hr.Msg();
        }
    }
}