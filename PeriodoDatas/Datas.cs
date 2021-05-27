using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PeriodoAtras
{
    public class Datas
    {
        public void DiferencaData()
        {
            DateTime data1, data2;
            TimeSpan resultado;


            data1 = DateTime.Now;

            //Console.WriteLine("Digite a data que deseja ver a diferença");
            data2 = DateTime.Parse("12/04/2022");

            resultado = data1 - data2;


            if (data2 > data1)
            {
                Console.WriteLine("Data está no futuro.Tente Novamente");
            }
            else
            {

                Console.WriteLine(data1);
                Console.WriteLine(data2);
                Console.WriteLine();
                Console.WriteLine($"A diferença é {resultado.Days / 365 } anos atrás");
                Console.WriteLine($"A diferença é {resultado.Days / 30  } meses atrás");
                Console.WriteLine($"A diferença é {resultado.Days / 7  } semanas atrás ");
                Console.WriteLine($"A diferença é {resultado.Days} dias atrás ");
                Console.WriteLine($"A diferença é {resultado.Hours} horas atrás ");
                Console.WriteLine($"A diferença é {resultado.Minutes} minutos atrás ");
                Console.WriteLine($"A diferença é {resultado.Seconds} segundos atrás ");
            }

            Console.ReadLine();

        }

    }
}

