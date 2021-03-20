using System;

namespace Std{

    class Principal{
        
        public static void Main(string[] args){

            byte ContadorDosAprovados,ContadorDosRecuperacao,ContadorDosReprovados,i,QntdDeAlunos;
            float Nota1,Nota2,Nota3,Nota4;
            double NotaFinal;
            QntdDeAlunos=ContadorDosAprovados=ContadorDosRecuperacao=ContadorDosReprovados=0;
            i=1;

            Console.WriteLine("\n                               PROGRAMA\n");

            do{
                Console.Write("\nDigite a quantidade de alunos que há na sala: ");
                QntdDeAlunos=byte.Parse(Console.ReadLine());

                if(QntdDeAlunos <= 0 || QntdDeAlunos > 100){
                    Console.WriteLine("\n       [ERROR] Value not valid :(\n\n");
                }
            }
            while(QntdDeAlunos <= 0 || QntdDeAlunos > 100);
            while(i <= QntdDeAlunos){
                do{
                    Console.Write("\nDigite a nota do 1º bimestre: ");
                    Nota1=float.Parse(Console.ReadLine());

                    if(Nota1 < 0 || Nota1 > 10){
                        Console.WriteLine("\n       [ERROR] Note not valid :(\n\n");
                    }
                }
                while(Nota1 < 0 || Nota1 > 10);
                do{
                    Console.Write("\nDigite a nota do 2º bimestre: ");
                    Nota2=float.Parse(Console.ReadLine());

                    if(Nota2 < 0 || Nota2 > 10){
                        Console.WriteLine("\n       [ERROR] Note not valid :(\n\n");
                    }
                }
                while(Nota2 < 0 || Nota2 > 10);
                do{
                    Console.Write("\nDigite a nota do 3º bimestre: ");
                    Nota3=float.Parse(Console.ReadLine());

                    if(Nota3 < 0 || Nota3 > 10){
                        Console.WriteLine("\n       [ERROR] Note not valid :(\n\n");
                    }
                }
                while(Nota3 < 0 || Nota3 > 10);
                do{
                    Console.Write("\nDigite a nota do 4º bimestre: ");
                    Nota4=float.Parse(Console.ReadLine());

                    if(Nota4 < 0 || Nota4 > 10){
                        Console.WriteLine("\n       [ERROR] Note not valid :(\n\n");
                    }
                }
                while(Nota4 < 0 || Nota4 > 10);

                NotaFinal=(Nota1+Nota2+Nota3+Nota4)/4;

                if(NotaFinal >= 0 && NotaFinal < 4){
                    ContadorDosReprovados++;
                }
                else if(NotaFinal >= 4 && NotaFinal < 7){
                    ContadorDosRecuperacao++;
                }
                else{
                    if(NotaFinal > 7){
                        ContadorDosAprovados++;
                    }
                }
                Console.WriteLine("\n-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_\n");
                i++;
            }
            Console.WriteLine("\n\n          Tivemos ao todo, {0} aluno(s) APROVADO(S), {1} aluno(s) REPROVADO(S) e {2} alunos que ficaram em RECUPERAÇÃO.\n\n",ContadorDosAprovados,ContadorDosReprovados,ContadorDosRecuperacao);
        }
    }
}