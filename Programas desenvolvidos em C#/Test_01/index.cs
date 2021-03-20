using System;

namespace Std
{
    struct Clubes
    {
        public string Nome;
        public byte Dia;
        string Mes;
        short Ano;
        string Cor;
        int IdadeDoClube;
        byte Mundiais, CopaIntercontinental, CopaRio, RecopaDosCampeoesIntercontinentais, CopaLibertadoresDaAmerica, CopaSulAmericana, CopaMercosul, RecopaSulAmericana;
        byte CopaCONMEBOL, SupercopaLibertadores, CopaMasterDaConmebol, SupercopaSulAmericanaDosCampeoesIntercontinentais, NumeroDeTitulosInter, CampeonatoBrasileiro;
        byte CopaDoBrasil, SupercopaDoBrasil, CopaDosCampeoesMundiais, CopaDosCampeoes, NumeroDeTitulosNacionais, NumeroDeTitulosTotais;

        public Clubes(string Nome, byte Dia, string Mes, short Ano, string Cor, int IdadeDoClube, byte Mundiais, byte CopaIntercontinental, byte CopaRio, byte RecopaDosCampeoesIntercontinentais, byte CopaLibertadoresDaAmerica, byte CopaSulAmericana, byte CopaMercosul, byte RecopaSulAmericana, byte CopaCONMEBOL, byte SupercopaLibertadores, byte CopaMasterDaConmebol, byte SupercopaSulAmericanaDosCampeoesIntercontinentais, byte NumeroDeTitulosInter, byte CampeonatoBrasileiro, byte CopaDoBrasil, byte SupercopaDoBrasil, byte CopaDosCampeoesMundiais, byte CopaDosCampeoes, byte NumeroDeTitulosNacionais, byte NumeroDeTitulosTotais)
        {
            this.Nome = Nome;
            this.Dia = Dia;
            this.Mes = Mes;
            this.Ano = Ano;
            this.Cor = Cor;
            this.IdadeDoClube = IdadeDoClube;
            this.Mundiais = Mundiais;
            this.CopaIntercontinental = CopaIntercontinental;
            this.CopaRio = CopaRio;
            this.RecopaDosCampeoesIntercontinentais = RecopaDosCampeoesIntercontinentais;
            this.CopaLibertadoresDaAmerica = CopaLibertadoresDaAmerica;
            this.CopaSulAmericana = CopaSulAmericana;
            this.CopaMercosul = CopaMercosul;
            this.RecopaSulAmericana = RecopaSulAmericana;
            this.CopaCONMEBOL = CopaCONMEBOL;
            this.SupercopaLibertadores = SupercopaLibertadores;
            this.CopaMasterDaConmebol = CopaMasterDaConmebol;
            this.SupercopaSulAmericanaDosCampeoesIntercontinentais = SupercopaSulAmericanaDosCampeoesIntercontinentais;
            this.NumeroDeTitulosInter = NumeroDeTitulosInter;
            this.CampeonatoBrasileiro = CampeonatoBrasileiro;
            this.CopaDoBrasil = CopaDoBrasil;
            this.SupercopaDoBrasil = SupercopaDoBrasil;
            this.CopaDosCampeoesMundiais = CopaDosCampeoesMundiais;
            this.CopaDosCampeoes = CopaDosCampeoes;
            this.NumeroDeTitulosNacionais = NumeroDeTitulosNacionais;
            this.NumeroDeTitulosTotais = NumeroDeTitulosTotais;
        }

        public void Info()
        {
            Console.WriteLine("\n\n                                         {0}\n",this.Nome);
            Console.WriteLine("Data de fundação_ {0} de {1} de {2}",this.Dia,Mes,Ano);
            Console.WriteLine("Cores do clube___ {0}",this.Cor);
            Console.WriteLine("Idade do clube___ {0} anos",this.IdadeDoClube);
            Console.WriteLine("\n\n-_-_-_-_-_-_-_-_-_-_-_-_-_-_ * MUNDIAIS * -_-_-_-_-_-_-_-_-_-_-_-_-_-_\n");
            Console.WriteLine("{0} Copa(s) do Mundo de Clubes da FIFA",this.Mundiais);
            Console.WriteLine("{0} Copa(s) Intercontinentais",this.CopaIntercontinental);
            Console.WriteLine("\n\n-_-_-_-_-_-_-_-_-_-_-_-_-_-_ * INTERCONTINENTAIS * -_-_-_-_-_-_-_-_-_-_-_-_-_-_\n");
            Console.WriteLine("{0} Copa(s) Rio",this.CopaRio);
            Console.WriteLine("{0} Recopa(s) Intercontinental",this.RecopaDosCampeoesIntercontinentais);
            Console.WriteLine("\n\n-_-_-_-_-_-_-_-_-_-_-_-_-_-_ * CONTINENTAIS * -_-_-_-_-_-_-_-_-_-_-_-_-_-_\n");
            Console.WriteLine("{0} Copa(s) Libertdores da América",this.CopaLibertadoresDaAmerica);
            Console.WriteLine("{0} Copa(s) Sul-Americana",this.CopaSulAmericana);
            Console.WriteLine("{0} Copa(s) Mercosul",this.CopaMercosul);
            Console.WriteLine("{0} Recopa(s) Sul-Americana",this.RecopaSulAmericana);
            Console.WriteLine("{0} Copa(s) Conmebol",this.CopaCONMEBOL);
            Console.WriteLine("{0} Supercopa Libertadores",this.SupercopaLibertadores);
            Console.WriteLine("{0} Copa(s) Master da Conmebol",this.CopaMasterDaConmebol);
            Console.WriteLine("{0} Supercopa Sul-Americana dos Campeões Intercontinentais",this.SupercopaSulAmericanaDosCampeoesIntercontinentais);
            Console.WriteLine("\nTOTAIS DE TÍTULOS INTERNACIONAIS: {0}\n",this.NumeroDeTitulosInter);
            Console.WriteLine("\n\n-_-_-_-_-_-_-_-_-_-_-_-_-_-_ * NACIONAIS * -_-_-_-_-_-_-_-_-_-_-_-_-_-_\n");
            Console.WriteLine("{0} Campeonatos brasileiros",this.CampeonatoBrasileiro);
            Console.WriteLine("{0} Copa(s) do Brasil",this.CopaDoBrasil);
            Console.WriteLine("{0} Supercopa(s) do Brasil",this.SupercopaDoBrasil);
            Console.WriteLine("{0} Copa(s) dos Campões Mundiais",this.CopaDosCampeoesMundiais);
            Console.WriteLine("{0} Copa(s) dos Campões",this.CopaDosCampeoes);
            Console.WriteLine("\nTOTAIS DE TÍTULOS NACIONAIS: {0}\n",this.NumeroDeTitulosNacionais);
            Console.WriteLine("\n\nNÚMERO DE TÍTULOS EXPRESSIVOS: {0}\n",this.NumeroDeTitulosTotais);
            Console.WriteLine("\n__________________________________________________________________________________________________________________________\n");
        }
    }
    class Principal
    {
        public static void Main(string[] args)
        {
            Clubes Equipe1 = new Clubes("SÃO PAULO F.C.",25,"Janeiro",1930,"Preto, Branco e Vermelho",((DateTime.Now.Year)-1930),1,2,0,0,3,1,0,2,1,1,1,0,(1+2+3+1+2+1+1+1),6,0,0,2,0,(6+2),((1+2+3+1+2+1+1+1)+(6+2)));
            Clubes Equipe2 = new Clubes("SANTOS F.C.",14,"Abril",1912,"Preto e Branco",((DateTime.Now.Year)-1912),0,2,0,1,3,0,0,1,1,0,0,1,(2+1+3+1+1+1),8,1,0,0,0,(8+1),((2+1+3+1+1+1)+(8+1)));
            Clubes Equipe3 = new Clubes("S.E. PALMEIRAS",26,"Agosto",1914,"Verde e Branco",((DateTime.Now.Year)-1914),0,0,1,0,2,0,1,0,0,0,0,0,(1+2+1),10,4,0,0,1,(10+4+1),((1+2+1)+(10+4+1)));
            Clubes Equipe4 = new Clubes("S.C. CORINTHIANS P.",1,"Setembro",1910,"Preto e Branco",((DateTime.Now.Year)-1910),2,0,0,0,1,0,0,1,0,0,0,0,(2+1+1),7,3,1,0,0,(7+3+1),((2+1+1)+(7+3+1)));

            Equipe1.Info();
            Equipe2.Info();
            Equipe3.Info();
            Equipe4.Info();
        }
    }
}