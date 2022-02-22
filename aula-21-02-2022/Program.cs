using System;

namespace aula_21_02_2022
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Hello Word

            //Console.WriteLine("Hello World!");

            #endregion Hello Word

            #region Tipo de Valor

            #region Exemplo

            Console.WriteLine("Tipo de Valor");
            int numerico1 = 13;
            int numerico2 = numerico1;
            numerico1 = 20;

            Console.WriteLine(nameof(numerico1) + ':' + numerico1);
            Console.WriteLine(nameof(numerico2) + ':' + numerico2);
            Console.WriteLine("\n");
            
            #endregion Exemplo

            #region Tipo Inteiro

            Console.WriteLine("Tipo inteiro");
            Console.WriteLine("Valor mínimo: " + int.MinValue);
            Console.WriteLine("Valor máximo: " + int.MaxValue);
            Console.WriteLine("\n");

            #endregion Tipo Inteiro

            #region Tipo Ponto Flutuante

            Console.WriteLine("Tipo ponto flutuante");
            Console.WriteLine("Valor mínimo float: " + float.MinValue);
            Console.WriteLine("Valor máximo float: " + float.MaxValue);
            Console.WriteLine("Valor mínimo double: " + double.MinValue);
            Console.WriteLine("Valor máximo double: " + double.MaxValue);

            #endregion Tipo Ponto Flutuante

            #region Tipo Decimal

            Console.WriteLine("Tipo decimal");
            Console.WriteLine("Valor mínimo: " + decimal.MinValue);
            Console.WriteLine("Valor máximo: " + decimal.MaxValue);
            Console.WriteLine("\n");

            #endregion Tipo Decimal

            #region Tipo Booleano

            Console.WriteLine("Tipo booleano");

            bool booleano1 = false;
            bool booleano2 = true;

            Console.WriteLine(nameof(booleano1) + ':' + booleano1);
            Console.WriteLine(nameof(booleano2) + ':' + booleano2);
            Console.WriteLine("\n");

            #endregion Tipo Booleano

            #region Tipo Data

            Console.WriteLine("Tipo data");

            DateTime dataAtualComHora = DateTime.Now;
            DateTime dataAtualSemHora = DateTime.Today;
            DateTime dataAtualMaisUmDia = DateTime.Now.AddDays(1);
            DateTime dataAtualMenosUmDia = DateTime.Now.AddDays(-1);
            DateTime dataAtualMaisUmMes = DateTime.Now.AddMonths(1);
            DateTime dataAtualMenosUmMes = DateTime.Now.AddMonths(-1);
            DateTime dataAtualMaisUmAno = DateTime.Now.AddYears(1);
            DateTime dataAtualMenosUmAno = DateTime.Now.AddYears(-1);

            Console.WriteLine(nameof(dataAtualComHora) + ':' + dataAtualComHora);
            Console.WriteLine(nameof(dataAtualSemHora) + ':' + dataAtualSemHora);
            Console.WriteLine(nameof(dataAtualMaisUmDia) + ':' + dataAtualMaisUmDia);
            Console.WriteLine(nameof(dataAtualMenosUmDia) + ':' + dataAtualMenosUmDia);
            Console.WriteLine(nameof(dataAtualMaisUmMes) + ':' + dataAtualMaisUmMes);
            Console.WriteLine(nameof(dataAtualMenosUmMes) + ':' + dataAtualMenosUmMes);
            Console.WriteLine(nameof(dataAtualMaisUmAno) + ':' + dataAtualMaisUmAno);
            Console.WriteLine(nameof(dataAtualMenosUmAno) + ':' + dataAtualMenosUmAno);
            Console.WriteLine("\n");

            #endregion Tipo Data

            #region Tipo Enumeração

            Console.WriteLine("Tipo enumeração");

            TipoCliente normal = TipoCliente.Normal;
            TipoCliente funcionario = TipoCliente.Funcionario;

            Console.WriteLine(nameof(normal) + ':'+ normal);
            Console.WriteLine(nameof(funcionario) + ':' + funcionario);
            Console.WriteLine("\n");

            #endregion Tipo Enumeração

            #endregion Tipo de Valor

            #region Tipo de Referencia

            #region Estrutura

            PosicaoGPS posicaoGPS1 = new PosicaoGPS()
            {
                Latitude = 1.11,
                Longitude = 5.33,
            };

            PosicaoGPS posicaoGPS2 = posicaoGPS1;

            posicaoGPS1 = new PosicaoGPS()
            {
                Latitude = -3.89,
                Longitude = 5.44,
            };


            Console.WriteLine(nameof(posicaoGPS1)
                + ": Latitude - " + posicaoGPS1.Latitude
                + " Longitude - " + posicaoGPS1.Longitude
                + " Está no hemisfério norte - " + posicaoGPS1.IsHemisferioNorte());

            Console.WriteLine(nameof(posicaoGPS2)
                + ": Latitude - " + posicaoGPS2.Latitude
                + " Longitude - " + posicaoGPS2.Longitude
                + " Está no hemisfério norte - " + posicaoGPS2.IsHemisferioNorte());

            #endregion Estrutura

            #endregion Tipo de Referencia

            Console.ReadKey();
        }
    }

    enum TipoCliente
    {
        Normal,
        Funcionario,
        Socio,
    }

    struct PosicaoGPS
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public bool IsHemisferioNorte()
        {
            return Latitude > 0;
        }
    }
}