using System;

namespace Std
{
    class Esportivos
    {
        string NomeDoVeiculo;
        short Cilindros,Valvulas,Cilindrada,RotacaoMaxima,PotenciaMaxima1,PotenciaMaxima2,TorqueMaximo2,PortaMalas,Peso,Tanque,Carga;
        short VelocMaxima,Urbana,Rodoviaria;
        float PesoPotencia,PesoTorque,TorqueMaximo1,TorqueEspecifico,PotenciaEspecifica,Aceleracao,Urbano,Rodoviario;

        public Esportivos(byte a)
        {
            if(a < 1 || a > 3)
            {
                Console.WriteLine("\n   Error 404 :(\n");
            }
            else
            {
                if(a == 1)
                {
                    NomeDoVeiculo = "Lamborghini Gallardo LP 560-4 5.2 V10";
                    Cilindros = 10;
                    Valvulas = 4;
                    Cilindrada = 5204;
                    PesoPotencia = 2.7f;
                    PesoTorque = 27.2f;
                    RotacaoMaxima = 0000;
                    PotenciaMaxima1 = 560;
                    PotenciaMaxima2 = 8000;
                    TorqueMaximo1 = 55.1f;
                    TorqueMaximo2 = 6500;
                    TorqueEspecifico = 10.6f;
                    PotenciaEspecifica = 107.6f;
                    PortaMalas = 110;
                    Peso = 1500;
                    Tanque = 90;
                    Carga = 300;
                    VelocMaxima = 325;
                    Aceleracao = 3.7f;
                    Urbano = 3.2f;
                    Rodoviario = 6.6f;
                    Urbana = 288;
                    Rodoviaria = 594;
                }
                else if(a == 2)
                {
                    NomeDoVeiculo = "Ferrari F430 F1 4.3 V8";
                    Cilindros = 8;
                    Valvulas = 4;
                    Cilindrada = 4308;
                    PesoPotencia = 3;
                    PesoTorque = 30.6f;
                    RotacaoMaxima = 0000;
                    PotenciaMaxima1 = 490;
                    PotenciaMaxima2 = 8500;
                    TorqueMaximo1 = 47.4f;
                    TorqueMaximo2 = 5250;
                    TorqueEspecifico = 11;
                    PotenciaEspecifica = 113.7f;
                    PortaMalas = 250;
                    Peso = 1450;
                    Tanque = 95;
                    Carga = 270;
                    VelocMaxima = 315;
                    Aceleracao = 4;
                    Urbano = 3.1f;
                    Rodoviario = 5.9f;
                    Urbana = 295;
                    Rodoviaria = 561;
                }
                else
                {
                    if(a == 3)
                    {
                        NomeDoVeiculo = "Porsche 911 Turbo S 3.7";
                        Cilindros = 6;
                        Valvulas = 4;
                        Cilindrada = 3745;
                        PesoPotencia = 2.5f;
                        PesoTorque = 20.1f;
                        RotacaoMaxima = 7200;
                        PotenciaMaxima1 = 650;
                        PotenciaMaxima2 = 6750;
                        TorqueMaximo1 = 81.6f;
                        TorqueMaximo2 = 2500;
                        TorqueEspecifico = 21.8f;
                        PotenciaEspecifica = 173.6f;
                        PortaMalas = 392;
                        Peso = 1640;
                        Tanque = 68;
                        Carga = 380;
                        VelocMaxima = 330;
                        Aceleracao = 2.7f;
                        Urbano = 6.9f;
                        Rodoviario = 9.1f;
                        Urbana = 469;
                        Rodoviaria = 619;
                    }
                }
            }
        }

        public void Info()
        {
            Console.WriteLine("\n                   {0}\n",NomeDoVeiculo);
            Console.WriteLine("\n\n                   MOTOR\n");
            Console.WriteLine("Cilindros____________ {0} em V",Cilindros);
            Console.WriteLine("Válvulas por cilindro {0}",Valvulas);
            Console.WriteLine("Cilindrada___________ {0} cm³",Cilindrada);
            Console.WriteLine("Peso/potência________ {0} kg/cv",PesoPotencia);
            Console.WriteLine("Peso/torque__________ {0} kg/kgfm",PesoTorque);
            Console.WriteLine("Rotação máxima_______ {0} rpm",RotacaoMaxima);
            Console.WriteLine("Potência máxima______ {0} cv a {1} rpm",PotenciaMaxima1,PotenciaMaxima2);
            Console.WriteLine("Torque máximo________ {0} kgfm a {1} rpm",TorqueMaximo1,TorqueMaximo2);
            Console.WriteLine("Torque específico____ {0} kgfm/l",TorqueEspecifico);
            Console.WriteLine("Potência específica__ {0} cv/l",PotenciaEspecifica);
            Console.WriteLine("\n\n                       DIMENSÕES\n");
            Console.WriteLine("Porta-malas__________ {0} l",PortaMalas);
            Console.WriteLine("Peso_________________ {0} kg",Peso);
            Console.WriteLine("Tanque de combustível {0} l",Tanque);
            Console.WriteLine("Carga útil___________ {0} kg",Carga);
            Console.WriteLine("\n\n                       DESEMPENHO\n");
            Console.WriteLine("Velocidade máxima____ {0} km/h",VelocMaxima);
            Console.WriteLine("Aceleração 0-100 km/h {0} s",Aceleracao);
            Console.WriteLine("\n\n                       CONSUMO\n");
            Console.WriteLine("Urbano_______________ {0} km/l",Urbano);
            Console.WriteLine("Rodoviário___________ {0} km/l",Rodoviario);
            Console.WriteLine("\n\n                       AUTONOMIA\n");
            Console.WriteLine("Urbana_______________ {0} km",Urbana);
            Console.WriteLine("Rodoviária___________ {0} km",Rodoviaria);
            Console.WriteLine("\n\n-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_\n\n");
        }
    }
    class None
    {
        public static void Main(string[] args)
        {
            Esportivos Car1 = new Esportivos(1);
            Esportivos Car2 = new Esportivos(2);
            Esportivos Car3 = new Esportivos(3);

            Car1.Info();
            Car2.Info();
            Car3.Info();
        }
    }
}