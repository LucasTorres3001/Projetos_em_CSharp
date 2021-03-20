using System;

namespace Std
{
    class Futebol
    {
        public string NomeDoClube, CoresDoClube, MesDeFundacao;
        public short AnoDeFundacao;
        public int DiaDeFundacao, MundialFIFA, CopaIntercont, CopaRio, RecopaDosCampeõesIntercontinentais, CopaLibertadoresDaAmerica, CopaSulAmericana;
        public int CopaMercosul, RecopaSulAmericana, CopaConmebol, SupercopaLibertadores, CopaMasterDaConmebol, SupercopaSulAmericanaDosCampeoesIntercontinentais;
        public int TitulosInternacionais, CampeonatoBrasileiro, CopaDoBrasil, SupercopaDoBrasil, CopaDosCampeoesMundiais, CopaDosCampeoes, TitulosNacionais;
        public int TitulosTotais;
        
        public Futebol(byte a)
        {
            if(a < 1)
            {
                Console.WriteLine("\n       Error 404 :(\n");
            }
            else{
                if(a == 1)
                {
                    NomeDoClube = "São Paulo F.C.";
                    DiaDeFundacao = 25;
                    MesDeFundacao = "Janeiro";
                    AnoDeFundacao = 1930;
                    CoresDoClube = "Preto, Branco e Vermelho";
                    MundialFIFA = 1;
                    CopaIntercont = 2;
                    CopaRio = 0;
                    RecopaDosCampeõesIntercontinentais = 0;
                    CopaLibertadoresDaAmerica = 3;
                    CopaSulAmericana = 1;
                    CopaMercosul = 0;
                    RecopaSulAmericana = 2;
                    CopaConmebol = 1;
                    SupercopaLibertadores = 1;
                    CopaMasterDaConmebol = 1;
                    SupercopaSulAmericanaDosCampeoesIntercontinentais = 0;
                    TitulosInternacionais = MundialFIFA + CopaIntercont + CopaLibertadoresDaAmerica + CopaSulAmericana + RecopaSulAmericana + CopaConmebol + SupercopaLibertadores + CopaMasterDaConmebol;
                    CampeonatoBrasileiro = 6;
                    CopaDoBrasil = 0;
                    SupercopaDoBrasil = 0;
                    CopaDosCampeoesMundiais = 2;
                    CopaDosCampeoes = 0;
                    TitulosNacionais = CampeonatoBrasileiro + CopaDoBrasil + SupercopaDoBrasil + CopaDosCampeoesMundiais;
                    TitulosTotais = TitulosInternacionais + TitulosNacionais; 
                }
                else if(a == 2)
                {
                    NomeDoClube = "Santos F.C.";
                    DiaDeFundacao = 14;
                    MesDeFundacao = "Abril";
                    AnoDeFundacao = 1912;
                    CoresDoClube = "Preto e Branco";
                    MundialFIFA = 0;
                    CopaIntercont = 2;
                    CopaRio = 0;
                    RecopaDosCampeõesIntercontinentais = 1;
                    CopaLibertadoresDaAmerica = 3;
                    CopaSulAmericana = 0;
                    CopaMercosul = 0;
                    RecopaSulAmericana = 1;
                    CopaConmebol = 1;
                    SupercopaLibertadores = 0;
                    CopaMasterDaConmebol = 0;
                    SupercopaSulAmericanaDosCampeoesIntercontinentais = 1;
                    TitulosInternacionais = MundialFIFA + CopaIntercont + CopaLibertadoresDaAmerica + CopaSulAmericana + RecopaSulAmericana + CopaConmebol + RecopaDosCampeõesIntercontinentais + SupercopaSulAmericanaDosCampeoesIntercontinentais;
                    CampeonatoBrasileiro = 8;
                    CopaDoBrasil = 1;
                    SupercopaDoBrasil = 0;
                    CopaDosCampeoesMundiais = 0;
                    CopaDosCampeoes = 0;
                    TitulosNacionais = CampeonatoBrasileiro + CopaDoBrasil + SupercopaDoBrasil;
                    TitulosTotais = TitulosInternacionais + TitulosNacionais;
                }
                else if(a == 3)
                {
                    NomeDoClube = "S.E. Palmeiras";
                    DiaDeFundacao = 26;
                    MesDeFundacao = "Agosto";
                    AnoDeFundacao = 1914;
                    CoresDoClube = "Verde e Branco";
                    MundialFIFA = 0;
                    CopaIntercont = 0;
                    CopaRio = 1;
                    RecopaDosCampeõesIntercontinentais = 0;
                    CopaLibertadoresDaAmerica = 2;
                    CopaSulAmericana = 0;
                    CopaMercosul = 1;
                    RecopaSulAmericana = 0;
                    CopaConmebol = 0;
                    SupercopaLibertadores = 0;
                    CopaMasterDaConmebol = 0;
                    SupercopaSulAmericanaDosCampeoesIntercontinentais = 0;
                    TitulosInternacionais = MundialFIFA + CopaRio + CopaLibertadoresDaAmerica + CopaSulAmericana + RecopaSulAmericana + CopaMercosul;
                    CampeonatoBrasileiro = 10;
                    CopaDoBrasil = 4;
                    SupercopaDoBrasil = 0;
                    CopaDosCampeoesMundiais = 0;
                    CopaDosCampeoes = 1;
                    TitulosNacionais = CampeonatoBrasileiro + CopaDoBrasil + SupercopaDoBrasil + CopaDosCampeoes;
                    TitulosTotais = TitulosInternacionais + TitulosNacionais;
                }
                else if(a == 4)
                {
                    NomeDoClube = "S.C. Corinthians P.";
                    DiaDeFundacao = 1;
                    MesDeFundacao = "Setembro";
                    AnoDeFundacao = 1910;
                    CoresDoClube = "Preto e Branco";
                    MundialFIFA = 2;
                    CopaIntercont = 0;
                    CopaRio = 0;
                    RecopaDosCampeõesIntercontinentais = 0;
                    CopaLibertadoresDaAmerica = 1;
                    CopaSulAmericana = 0;
                    CopaMercosul = 0;
                    RecopaSulAmericana = 1;
                    CopaConmebol = 0;
                    SupercopaLibertadores = 0;
                    CopaMasterDaConmebol = 0;
                    SupercopaSulAmericanaDosCampeoesIntercontinentais = 0;
                    TitulosInternacionais = MundialFIFA + CopaLibertadoresDaAmerica + CopaSulAmericana + RecopaSulAmericana;
                    CampeonatoBrasileiro = 7;
                    CopaDoBrasil = 3;
                    SupercopaDoBrasil = 1;
                    CopaDosCampeoesMundiais = 0;
                    CopaDosCampeoes = 0;
                    TitulosNacionais = CampeonatoBrasileiro + CopaDoBrasil + SupercopaDoBrasil;
                    TitulosTotais = TitulosInternacionais + TitulosNacionais;
                }
                else
                {
                    if(a > 4)
                    {
                        Console.WriteLine("\n       Error 404 :(\n");
                    }
                }
            }
        }
        public void Info()
        {
            Console.WriteLine("\n\nNome do clube: {0}",NomeDoClube);
            Console.WriteLine("Data de fundação: {0} de {1} de {2}",DiaDeFundacao,MesDeFundacao,AnoDeFundacao);
            Console.WriteLine("Cores do clube__: {0}",CoresDoClube);
            Console.WriteLine("\n---------------------------- * MUNDIAIS * ----------------------------");
            Console.WriteLine(" - {0} Copa(s) do Mundo de Clubes da FIFA",MundialFIFA);
            Console.WriteLine(" - {0} Copa(s) Intercontinentais",CopaIntercont);
            Console.WriteLine(" - {0} Copa(s) Rio",CopaRio);
            Console.WriteLine("\n---------------------------- * INTERCONTINENTAIS * ----------------------------");
            Console.WriteLine(" - {0} Recopa(s) Intercontinental",RecopaDosCampeõesIntercontinentais);
            Console.WriteLine("\n---------------------------- * CONTINENTAIS * ----------------------------");
            Console.WriteLine(" - {0} Copa(s) Libertadores da América",CopaLibertadoresDaAmerica);
            Console.WriteLine(" - {0} Copa(s) Sul-Americana",CopaSulAmericana);
            Console.WriteLine(" - {0} Copa(s) Mercosul",CopaMercosul);
            Console.WriteLine(" - {0} Recopa(s) Sul-Americana",RecopaSulAmericana);
            Console.WriteLine(" - {0} Supercopa(s) Libertadores",SupercopaLibertadores);
            Console.WriteLine(" - {0} Copa(s) Conmebol",CopaConmebol);
            Console.WriteLine(" - {0} Copa(s) Master da Conmebol",CopaMasterDaConmebol);
            Console.WriteLine(" - {0} Supercopa(s) Sul-Americana dos Campeões Intercontinentais",SupercopaSulAmericanaDosCampeoesIntercontinentais);
            Console.WriteLine("\n - TOTAL DE TÍTULOS INTERNACIONAIS: {0} Títulos",TitulosInternacionais);
            Console.WriteLine("\n---------------------------- * NACIONAIS * ----------------------------");
            Console.WriteLine(" - {0} Campeonatos brasileiro",CampeonatoBrasileiro);
            Console.WriteLine(" - {0} Copa(s) do Brasil",CopaDoBrasil);
            Console.WriteLine(" - {0} Supercopa(s) do Brasil",SupercopaDoBrasil);
            Console.WriteLine(" - {0} Copa(s) dos Campeões Mundiais",CopaDosCampeoesMundiais);
            Console.WriteLine(" - {0} Copa(s) dos Campeões",CopaDosCampeoes);
            Console.WriteLine("\n - TOTAL DE TÍTULOS NACIONAIS: {0} Títulos\n",TitulosNacionais);
            Console.WriteLine("\n - TOTAL DE TÍTULOS EXPRESSIVOS: {0} Títulos\n",TitulosTotais);
            Console.WriteLine("\n\n-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-\n");
        }
    }
    class Principal
    {
        public static void Main(string[] args)
        {
            Futebol time1 = new Futebol(1);
            Futebol time2 = new Futebol(2);
            Futebol time3 = new Futebol(3);
            Futebol time4 = new Futebol(4);

            time1.Info();
            time2.Info();
            time3.Info();
            time4.Info();
        }
    }
}