using System;

namespace Std
{
    class Usuarios
    {
        string CidadeNatal,EstadoCivil,EtniaDoUsuario,MesDeNascimento,Nacionalidade,NomeDoUsuario,SexoDoUsuario,UF;
        int AnoAtual=DateTime.Now.Year;
        short AnoDeNascimento,n1,n2,n3;
        byte DiaDoNascimento,n4;
        int IdadeDoUsuario;
        float m;
        double h,imc;
        
        public Usuarios(byte a)
        {
            if(a < 1 || a > 4)
            {
                Console.WriteLine("\n   Error 404 :(\n\n");
            }
            else
            {
                if(a == 1)
                {
                    NomeDoUsuario = "Pedro Quintela";
                    DiaDoNascimento = 28;
                    MesDeNascimento = "Janeiro";
                    AnoDeNascimento = 1993;
                    CidadeNatal = "São João do Pau de Arara";
                    UF = "SP";
                    n1 = 124;
                    n2 = 864;
                    n3 = 218;
                    n4 = 64;
                    IdadeDoUsuario = AnoAtual-AnoDeNascimento;
                    SexoDoUsuario = "Masculino";
                    Nacionalidade = "brasileiro";
                    EtniaDoUsuario = "branco";
                    EstadoCivil = "Solteiro";
                    m = 90.2f;
                    h = 1.95;
                    imc = m/(h*h);
                }
                else if(a == 2)
                {
                    NomeDoUsuario = "Ana Júlia Ancilano da Fonseca";
                    DiaDoNascimento = 13;
                    MesDeNascimento = "Outubro";
                    AnoDeNascimento = 1987;
                    CidadeNatal = "Campina do Arroio";
                    UF = "SC";
                    n1 = 369;
                    n2 = 147;
                    n3 = 012;
                    n4 = 55;
                    IdadeDoUsuario = AnoAtual-AnoDeNascimento;
                    SexoDoUsuario = "Feminino";
                    Nacionalidade = "brasileira";
                    EtniaDoUsuario = "branca";
                    EstadoCivil = "Em relacionamento sério";
                    m = 66.5f;
                    h = 1.69;
                    imc = m/(h*h);
                }
                else if(a == 3)
                {
                    NomeDoUsuario = "Romoaldo Bronha da Silveira";
                    DiaDoNascimento = 21;
                    MesDeNascimento = "Julho";
                    AnoDeNascimento = 1967;
                    CidadeNatal = "Itapiroca";
                    UF = "AL";
                    n1 = 714;
                    n2 = 816;
                    n3 = 918;
                    n4 = 25;
                    IdadeDoUsuario = AnoAtual-AnoDeNascimento;
                    SexoDoUsuario = "Masculino";
                    Nacionalidade = "brasileiro";
                    EtniaDoUsuario = "cabloco";
                    EstadoCivil = "Largado";
                    m = 85.7f;
                    h = 1.77;
                    imc = m/(h*h);
                }
                else
                {
                    if(a == 4)
                    {
                        NomeDoUsuario = "Romilda da Conceição Soares";
                        DiaDoNascimento = 24;
                        MesDeNascimento = "Agosto";
                        AnoDeNascimento = 1959;
                        CidadeNatal = "Marcópolis";
                        UF = "MS";
                        n1 = 121;
                        n2 = 225;
                        n3 = 324;
                        n4 = 81;
                        IdadeDoUsuario = AnoAtual-AnoDeNascimento;
                        SexoDoUsuario = "Feminino";
                        Nacionalidade = "brasileira";
                        EtniaDoUsuario = "cafuza";
                        EstadoCivil = "Viúva";
                        m = 72.6f;
                        h = 1.65;
                        imc = m/(h*h);
                    }
                }
            }
        }
        public void Info()
        {
            Console.WriteLine("                           USUÁRIO\n");
            Console.WriteLine("Nome do Usuário____ {0}",NomeDoUsuario);
            Console.WriteLine("Data de nascimeto__ {0} de {1} de {2}",DiaDoNascimento,MesDeNascimento,AnoDeNascimento);
            Console.WriteLine("CPF________________ {0}.{1}.{2}-{3}",n1,n2,n3,n4);
            Console.WriteLine("Idade atual________ {0} anos",IdadeDoUsuario);
            Console.WriteLine("Cidade natal_______ {0} - {1}",CidadeNatal,UF);
            Console.WriteLine("Nacionalidade______ {0}",Nacionalidade);
            Console.WriteLine("Sexo_______________ {0}",SexoDoUsuario);
            Console.WriteLine("Etnia______________ {0}",EtniaDoUsuario);
            Console.WriteLine("Estado civil_______ {0}",EstadoCivil);
            Console.WriteLine("Peso_______________ {0} kg",m);
            Console.WriteLine("Altura_____________ {0} m",h);
            Console.WriteLine("I.M.C._____________ {0} kg/m²",imc.ToString("F"));
            Console.WriteLine("\n-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_\n\n");
        }
    }
    class None
    {
        public static void Main(string[] args)
        {
            Usuarios Pessoa1 = new Usuarios(1);
            Usuarios Pessoa2 = new Usuarios(2);
            Usuarios Pessoa3 = new Usuarios(3);
            Usuarios Pessoa4 = new Usuarios(4);

            Pessoa1.Info();
            Pessoa2.Info();
            Pessoa3.Info();
            Pessoa4.Info();
        }
    }
}