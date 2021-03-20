using System;

namespace Std
{
    class Principal
    {
        public static void Main(string[] args)
        {
            short i,AnoDeNasc,UsuariosMaioresDeIdade,UsuariosMenoresDeIdade;
            UsuariosMaioresDeIdade = UsuariosMenoresDeIdade = 0;
            int AnoAtual;
            AnoAtual = DateTime.Now.Year;

            Console.Clear();

            Console.WriteLine("                                                 PROGRAMA\n");

            for(i=1; i <= 7; i++)
            {
                do
                {
                    Console.Write("\nDigite o ano de nascimento do {0}º usuário: ",i);
                    AnoDeNasc = short.Parse(Console.ReadLine());

                    if(AnoDeNasc > AnoAtual || AnoDeNasc < (AnoAtual-130))
                    {
                        Console.WriteLine("\n     [Error] Year of birth invalid! :(\n\n");
                    }
                }
                while(AnoDeNasc > AnoAtual || AnoDeNasc < (AnoAtual-130));
                
                if((AnoAtual-AnoDeNasc) >= 0 && (AnoAtual-AnoDeNasc) < 18)
                {
                    UsuariosMenoresDeIdade++;
                }
                else
                {
                    if((AnoAtual-AnoDeNasc) >= 18)
                    {
                        UsuariosMaioresDeIdade++;
                    }
                }
            }
            Console.WriteLine("\n-    Você digitou {0} usuário(s) menor(es) de idade e {1} usuário(s) maior(es) de idade!\n",UsuariosMenoresDeIdade,UsuariosMaioresDeIdade);
        }
    }
}