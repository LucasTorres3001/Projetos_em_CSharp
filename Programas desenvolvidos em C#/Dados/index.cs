using System;

delegate double QualidadeDeVida(float m, double h);
delegate int IdadeDoUsuario(int AnoAtual, int AnoDeNasc);

namespace Std{

    class DadosDoUsuario{

        public static double IMC(float m, double h){
            if(m <= 0 || h <= 0){
                throw new Exception("                               Error 404 :( ...");
            }
            else{
                return m/(h*h);
            }
        }
        public static int Idade(int AnoAtual, int AnoDeNasc){
            if(AnoDeNasc < (AnoAtual-125) || AnoDeNasc > AnoAtual){
                throw new Exception("                               Error 404 :( ...");
            }
            else{
                return AnoAtual-AnoDeNasc;
            }
        }
    }
    class Home{

        public static void Main(string[] args){

            double Info;

            Info=0;

            QualidadeDeVida Saude = new QualidadeDeVida(DadosDoUsuario.IMC);

            try{
                Info = Saude(81.9f,1.84);

                if(Info > 0 && Info < 18.5){
                    Console.WriteLine("\n                       Índice de Massa Corporal(I.M.C.)\n\n- O imc do usuário deu {0} kg/m².\n\n- O usuário está ABAIXO DO PESO!\n",Info.ToString("F"));
                }
                else if(Info >= 18.5 && Info < 25){
                    Console.WriteLine("\n                       Índice de Massa Corporal(I.M.C.)\n\n- O imc do usuário deu {0} kg/m².\n\n- O usuário está com o PESO NORMAL!\n",Info.ToString("F"));
                }
                else if(Info >= 25 && Info < 30){
                    Console.WriteLine("\n                       Índice de Massa Corporal(I.M.C.)\n\n- O imc do usuário deu {0} kg/m².\n\n- O usuário está com SOBREPESO!\n",Info.ToString("F"));
                }
                else if(Info >= 30 && Info < 35){
                    Console.WriteLine("\n                       Índice de Massa Corporal(I.M.C.)\n\n- O imc do usuário deu {0} kg/m².\n\n- O usuário está com OBESIDADE GRAU 1\n",Info.ToString("F"));
                }
                else if(Info >= 35 && Info < 40){
                    Console.WriteLine("\n                       Índice de Massa Corporal(I.M.C.)\n\n- O imc do usuário deu {0} kg/m².\n\n- O usuário está com OBESIDADE GRAU 2\n",Info.ToString("F"));
                }
                else{
                    if(Info >= 40){
                        Console.WriteLine("\n                       Índice de Massa Corporal(I.M.C.)\n\n- O imc do usuário deu {0} kg/m².\n\n- O usuário está com OBESIDADE GRAU 3\n",Info.ToString("F"));
                    }
                }
            }
            catch(Exception a){
                Console.WriteLine("\n\n{0}\n",a.Message);
            }
            finally{
                Console.WriteLine("\n=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n");
            }

            int Res=0;

            IdadeDoUsuario AgeOfUser = new IdadeDoUsuario(DadosDoUsuario.Idade);

            Random n = new Random();
            int NumAleatorio = n.Next(1895,2120);

            try{
                Res = AgeOfUser(DateTime.Now.Year,NumAleatorio);

                Console.WriteLine("\n                              IDADE DO USUÁRIO\n\n- O usuário está, no momento, com {0} anos.\n",Res);
            }
            catch(Exception a){
                Console.WriteLine("\n\n{0}\n",a.Message);
            }
            finally{
                Console.WriteLine("\n                       Programa executado com sucesso!\n\n");
            }
        }
    }
}