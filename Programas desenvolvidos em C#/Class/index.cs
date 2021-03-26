using System;

//delegate double Nome(double m, double v, double d, short g);

namespace Std{

    class Usuarios{

        string NomeCompletoDoUsuario,MesDoNasc,CidadeNatal,UF,Nacionalidade,EtniaDoUsuario,SexoDoUsuario;
        short DiaDoNasc;
        int AnoDeNasc,IdadeDoUsuario;
        long CPF;
        double Massa,Altura,imc;

        public Usuarios(int a, string Nome, long CPF, string Mes, string LocalDeNasc, string Estado, string Nacao, string Etnia, string Sexo, short Dia, int Ano, int Idade, double M, double H, double IMC){
            if(a < 1 || a > 2){
                Console.WriteLine("                     Error :( ...");
            }
            else{
                if(a == 1){
                    NomeCompletoDoUsuario=Nome;
                    this.CPF=CPF;
                    DiaDoNasc=Dia;
                    MesDoNasc=Mes;
                    AnoDeNasc=Ano;
                    IdadeDoUsuario=Idade;
                    CidadeNatal=LocalDeNasc;
                    UF=Estado;
                    Nacionalidade=Nacao;
                    EtniaDoUsuario=Etnia;
                    SexoDoUsuario=Sexo;
                    Massa=M;
                    Altura=H;
                    imc=IMC;
                }
                else{
                    if(a == 2){
                        NomeCompletoDoUsuario=Nome;
                        this.CPF=CPF;
                        DiaDoNasc=Dia;
                        MesDoNasc=Mes;
                        AnoDeNasc=Ano;
                        IdadeDoUsuario=Idade;
                        CidadeNatal=LocalDeNasc;
                        UF=Estado;
                        Nacionalidade=Nacao;
                        EtniaDoUsuario=Etnia;
                        SexoDoUsuario=Sexo;
                        Massa=M;
                        Altura=H;
                        imc=Massa/(Altura*Altura);
                    }
                }
            }
        }
        public void Info(){

            Console.WriteLine("\n\n           INFORMAÇÕES DOS USUÁRIOS(AS)\n\n");
            Console.WriteLine("Nome do usuário(a)___ {0}\n",NomeCompletoDoUsuario);
            Console.WriteLine("CPF do usuário(a)____ {0}\n",this.CPF);
            Console.WriteLine("Data de nascimento___ {0} de {1} de {2}\n",DiaDoNasc,MesDoNasc,AnoDeNasc);
            Console.WriteLine("Idade________________ {0} anos\n",IdadeDoUsuario);
            Console.WriteLine("Local de nascimento__ {0} - {1}\n",CidadeNatal,UF);
            Console.WriteLine("Nacionalidade________ {0}\n",Nacionalidade);
            Console.WriteLine("Etnia________________ {0}\n",EtniaDoUsuario);
            Console.WriteLine("Sexo_________________ {0}\n",SexoDoUsuario);
            Console.WriteLine("Massa________________ {0} kg\n",Massa);
            Console.WriteLine("Altura_______________ {0} m\n",Altura);
            Console.WriteLine("I.M.C._______________ {0} kg/m²\n",imc.ToString("F"));
            Console.WriteLine("\n-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_\n\n");
        }
    }
    class Home{

        public static void Main(string[] args){

            //-------------------------------------------------------------- * Primeiro Usuário * --------------------------------------------------------------

            string Name,CityOfBirth,StatesOfBirth,Nationality,Ethnicity,SexOfUser;
            short DayOfBirth;
            int YearOfBirth;
            byte NumberOfMonth;
            long NumberOfIdentification;
            double Height,Weight;
            string[] MonthOfYear = {"Janeiro","Fevereiro","Março","Abril","Maio","Junho","Julho","Agosto","Setembro","Outubro","Novembro","Dezembro"};

            Console.WriteLine("\n               DADOS DO 1º USUÁRIO\n");

            Console.Write("\nDigite o nome do usuário(a): ");
            Name = Console.ReadLine();
            
            Console.Write("\nDigite o CPF do usuário(a): ");
            NumberOfIdentification = long.Parse(Console.ReadLine());
            do{
                Console.Write("\nDigite o número do mês de nascimento: ");
                NumberOfMonth = byte.Parse(Console.ReadLine());

                if(NumberOfMonth < 0 || NumberOfMonth > 12){
                    Console.WriteLine("\n    Month of birth not valid! :( ...\n\n");
                }
            }
            while(NumberOfMonth < 0 || NumberOfMonth > 12);
            do{
                Console.Write("\nDigite o dia de nascimento: ");
                DayOfBirth = short.Parse(Console.ReadLine());

                if((DayOfBirth < 0 || DayOfBirth > 31) || (DayOfBirth > 28 && NumberOfMonth==2) || (DayOfBirth > 30 && (NumberOfMonth==4 || NumberOfMonth==6 || NumberOfMonth==9 || NumberOfMonth==11))){
                    Console.WriteLine("\n    Day of birth not valid! :( ...\n\n");
                }
            }
            while((DayOfBirth < 0 || DayOfBirth > 31) || (DayOfBirth > 28 && NumberOfMonth==2) || (DayOfBirth > 30 && (NumberOfMonth==4 || NumberOfMonth==6 || NumberOfMonth==9 || NumberOfMonth==11)));
            do{
                Console.Write("\nDigite o ano de nascimento: ");
                YearOfBirth = int.Parse(Console.ReadLine());

                if(YearOfBirth < (DateTime.Now.Year-124) || YearOfBirth > DateTime.Now.Year){
                    Console.WriteLine("\n    Year of birth not valid! :( ...\n\n");
                }
            }
            while(YearOfBirth < (DateTime.Now.Year-124) || YearOfBirth > DateTime.Now.Year);
            
            Console.Write("\nDigite a cidade natal: ");
            CityOfBirth = Console.ReadLine();
            
            Console.Write("\nDigite o estado: ");
            StatesOfBirth = Console.ReadLine();
            
            Console.Write("\nDigite a nacionalidade do usuário(a): ");
            Nationality=Console.ReadLine();
            
            do{
                Console.Write("\nDigite a etnia do usuário(a): ");
                Ethnicity = Console.ReadLine();

                if((Ethnicity!="branco" && Ethnicity!="BRANCO" && Ethnicity!="Branco") && (Ethnicity!="negro" && Ethnicity!="NEGRO" && Ethnicity!="Negro") && (Ethnicity!="caboclo" && Ethnicity!="CABOCLO" && Ethnicity!="Caboclo") && (Ethnicity!="cafuzo" && Ethnicity!="CAFUZO" && Ethnicity!="Cafuzo") && (Ethnicity!="indigena" && Ethnicity!="INDIGENA" && Ethnicity!="Indigena") && (Ethnicity!="amarelo" && Ethnicity!="AMARELO" && Ethnicity!="Amarelo")){
                    Console.WriteLine("\n    Ethnicity of user not valid! :( ...\n\n");
                }
            }
            while((Ethnicity!="branco" && Ethnicity!="BRANCO" && Ethnicity!="Branco") && (Ethnicity!="negro" && Ethnicity!="NEGRO" && Ethnicity!="Negro") && (Ethnicity!="caboclo" && Ethnicity!="CABOCLO" && Ethnicity!="Caboclo") && (Ethnicity!="cafuzo" && Ethnicity!="CAFUZO" && Ethnicity!="Cafuzo") && (Ethnicity!="indigena" && Ethnicity!="INDIGENA" && Ethnicity!="Indigena") && (Ethnicity!="amarelo" && Ethnicity!="AMARELO" && Ethnicity!="Amarelo"));
            do{
                Console.Write("\nDigite o gênero do usuário(a): ");
                SexOfUser = Console.ReadLine();

                if(((SexOfUser!="f" && SexOfUser!="F") && (SexOfUser!="feminino" && SexOfUser!="FEMININO" && SexOfUser!="Feminino")) && ((SexOfUser!="f" && SexOfUser!="F") && (SexOfUser!="masculino" && SexOfUser!="MASCULINO" && SexOfUser!="Masculino"))){
                    Console.WriteLine("\n    Sex of user not valid! :( ...\n\n");
                }
            }
            while(((SexOfUser!="f" && SexOfUser!="F") && (SexOfUser!="feminino" && SexOfUser!="FEMININO" && SexOfUser!="Feminino")) && ((SexOfUser!="m" && SexOfUser!="M") && (SexOfUser!="masculino" && SexOfUser!="MASCULINO" && SexOfUser!="Masculino")));
            do{
                Console.Write("\nDigite a massa do usuário(a): ");
                Weight = double.Parse(Console.ReadLine());

                if(Weight <= 0 || Weight > 361){
                    Console.WriteLine("\n    Mass of user not valid! :( ...\n\n");
                }
            }
            while(Weight <= 0 || Weight > 361);
            do{
                Console.Write("\nDigite a altura do usuário(a): ");
                Height=double.Parse(Console.ReadLine());

                if(Height <= 0 || Height > 2.88){
                    Console.WriteLine("\n    Height of user not valid! :( ...\n\n");
                }
            }
            while(Height <= 0 || Height > 2.88);
            Console.Clear();

            //-------------------------------------------------------------- * Segundo Usuário * --------------------------------------------------------------

            string Name2,CityOfBirth2,StateOfBirth2,Nationality2,Ethnicity2,SexOfUser2;
            short DayOfBirth2;
            int YearOfBirth2;
            byte NumberOfMonth2;
            long NumberOfIdentification2;
            double Height2,Weight2;
            string[] MonthOfYear2 = {"Janeiro","Fevereiro","Março","Abril","Maio","Junho","Julho","Agosto","Setembro","Outubro","Novembro","Dezembro"};

            Console.WriteLine("\n               DADOS DO 2º USUÁRIO\n");

            Console.Write("\nDigite o nome do usuário(a): ");
            Name2 = Console.ReadLine();
            
            Console.Write("\nDigite o CPF do usuário(a): ");
            NumberOfIdentification2 = long.Parse(Console.ReadLine());
            do{
                Console.Write("\nDigite o número do mês de nascimento: ");
                NumberOfMonth2 = byte.Parse(Console.ReadLine());

                if(NumberOfMonth2 < 0 || NumberOfMonth2 > 12){
                    Console.WriteLine("\n    Month of birth not valid! :( ...\n\n");
                }
            }
            while(NumberOfMonth2 < 0 || NumberOfMonth2 > 12);
            do{
                Console.Write("\nDigite o dia de nascimento: ");
                DayOfBirth2 = short.Parse(Console.ReadLine());

                if((DayOfBirth2 < 0 || DayOfBirth2 > 31) || (DayOfBirth2 > 28 && NumberOfMonth2==2) || (DayOfBirth2 > 30 && (NumberOfMonth2==4 || NumberOfMonth2==6 || NumberOfMonth2==9 || NumberOfMonth2==11))){
                    Console.WriteLine("\n    Day of birth not valid! :( ...\n\n");
                }
            }
            while((DayOfBirth2 < 0 || DayOfBirth2 > 31) || (DayOfBirth2 > 28 && NumberOfMonth2==2) || (DayOfBirth2 > 30 && (NumberOfMonth2==4 || NumberOfMonth2==6 || NumberOfMonth2==9 || NumberOfMonth2==11)));
            do{
                Console.Write("\nDigite o ano de nascimento: ");
                YearOfBirth2 = int.Parse(Console.ReadLine());

                if(YearOfBirth2 < (DateTime.Now.Year-124) || YearOfBirth2 > DateTime.Now.Year){
                    Console.WriteLine("\n    Year of birth not valid! :( ...\n\n");
                }
            }
            while(YearOfBirth2 < (DateTime.Now.Year-124) || YearOfBirth2 > DateTime.Now.Year);
            
            Console.Write("\nDigite a cidade natal: ");
            CityOfBirth2 = Console.ReadLine();
            
            Console.Write("\nDigite o estado: ");
            StateOfBirth2 = Console.ReadLine();
            
            Console.Write("\nDigite a nacionalidade do usuário(a): ");
            Nationality2 = Console.ReadLine();
            
            do{
                Console.Write("\nDigite a etnia do usuário(a): ");
                Ethnicity2 = Console.ReadLine();

                if((Ethnicity2!="branco" && Ethnicity2!="BRANCO" && Ethnicity2!="Branco") && (Ethnicity2!="negro" && Ethnicity2!="NEGRO" && Ethnicity2!="Negro") && (Ethnicity2!="caboclo" && Ethnicity2!="CABOCLO" && Ethnicity2!="Caboclo") && (Ethnicity2!="cafuzo" && Ethnicity2!="CAFUZO" && Ethnicity2!="Cafuzo") && (Ethnicity2!="indigena" && Ethnicity2!="INDIGENA" && Ethnicity2!="Indigena") && (Ethnicity2!="amarelo" && Ethnicity2!="AMARELO" && Ethnicity2!="Amarelo")){
                    Console.WriteLine("\n    Ethnicity not valid! :( ...\n\n");
                }
            }
            while((Ethnicity2!="branco" && Ethnicity2!="BRANCO" && Ethnicity2!="Branco") && (Ethnicity2!="negro" && Ethnicity2!="NEGRO" && Ethnicity2!="Negro") && (Ethnicity2!="caboclo" && Ethnicity2!="CABOCLO" && Ethnicity2!="Caboclo") && (Ethnicity2!="cafuzo" && Ethnicity2!="CAFUZO" && Ethnicity2!="Cafuzo") && (Ethnicity2!="indigena" && Ethnicity2!="INDIGENA" && Ethnicity2!="Indigena") && (Ethnicity2!="amarelo" && Ethnicity2!="AMARELO" && Ethnicity2!="Amarelo"));
            do{
                Console.Write("\nDigite o gênero do usuário(a): ");
                SexOfUser2 = Console.ReadLine();

                if(((SexOfUser2!="f" && SexOfUser2!="F") && (SexOfUser2!="feminino" && SexOfUser2!="FEMININO" && SexOfUser2!="Feminino")) && ((SexOfUser2!="f" && SexOfUser2!="F") && (SexOfUser2!="masculino" && SexOfUser2!="MASCULINO" && SexOfUser2!="Masculino"))){
                    Console.WriteLine("\n    Sex of user not valid! :( ...\n\n");
                }
            }
            while(((SexOfUser2!="f" && SexOfUser2!="F") && (SexOfUser2!="feminino" && SexOfUser2!="FEMININO" && SexOfUser2!="Feminino")) && ((SexOfUser2!="m" && SexOfUser2!="M") && (SexOfUser2!="masculino" && SexOfUser2!="MASCULINO" && SexOfUser2!="Masculino")));
            do{
                Console.Write("\nDigite a massa do usuário(a): ");
                Weight2=double.Parse(Console.ReadLine());

                if(Weight2 <= 0 || Weight2 > 361){
                    Console.WriteLine("\n    Mass of user not valid! :( ...\n\n");
                }
            }
            while(Weight2 <= 0 || Weight2 > 361);
            do{
                Console.Write("\nDigite a altura do usuário(a): ");
                Height2 = double.Parse(Console.ReadLine());

                if(Height2 <= 0 || Height2 > 2.88){
                    Console.WriteLine("\n    Height of user not valid! :( ...\n\n");
                }
            }
            while(Height2 <= 0 || Height2 > 2.88);
            Console.Clear();

            //------------------------------------------------------- * Impresão dos método da classe * --------------------------------------------------------

            Usuarios Individuo = new Usuarios(1,Name,NumberOfIdentification,MonthOfYear[NumberOfMonth-1],CityOfBirth,StatesOfBirth,Nationality,Ethnicity,SexOfUser,DayOfBirth,YearOfBirth,(DateTime.Now.Year-YearOfBirth),Weight,Height,(Weight/(Height*Height)));

            Usuarios Individuo2 = new Usuarios(2,Name2,NumberOfIdentification2,MonthOfYear2[NumberOfMonth2-1],CityOfBirth2,StateOfBirth2,Nationality2,Ethnicity2,SexOfUser2,DayOfBirth2,YearOfBirth2,(DateTime.Now.Year-YearOfBirth2),Weight2,Height2,(Weight2/(Height2*Height2)));

            Individuo.Info();
            Individuo2.Info();
        }
    }
}