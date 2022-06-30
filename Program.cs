using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provaex2
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            DateTime data_atual;
            string c = null, mes = null;
            int cidade, d, m, a;

            Console.WriteLine("Digíte o código da cidade \n1-Atibaia \n2-Bragança Paulista \n3-Mairiporã \n4-Nazaré \n5-Terra Preta \n6-Extrema \n7-Vargem");
            cidade = int.Parse(Console.ReadLine());

            switch (cidade) 
            {
                case 1:
                    c = "Atibaia";
                    break;
                case 2:
                    c = "Bragança Paulista";
                    break;
                case 3:
                    c = "Mairiporã";
                    break;
                case 4:
                    c = "Nazaré";
                    break;
                case 5:
                    c = "Terra Preta";
                    break;
                case 6:
                    c = "Extrema";
                    break;
                case 7:
                    c = "Vargem";
                    break;
            }

            Console.WriteLine("Qual a data (com barras)");
            data_atual = Convert.ToDateTime(Console.ReadLine());

            d = data_atual.Day;
            m = data_atual.Month;
            a = data_atual.Year;

            switch(m) 
            {
                case 1:
                    mes = "Janeiro";
                    break;
                case 2:
                    mes = "Fevereiro";
                    break;
                case 3:
                    mes = "Março";
                    break;
                case 4:
                    mes = "Abril";
                    break;
                case 5:
                    mes = "Maio";
                    break;
                case 6:
                    mes = "Junho";
                    break;
                case 7:
                    mes = "Julho";
                    break;
                case 8:
                    mes = "Agosto";
                    break;
                case 9:
                    mes = "Setembro";
                    break;
                case 10:
                    mes = "Outubro";
                    break;
                case 11:
                    mes = "Novembro";
                    break;
                case 12:
                    mes = "Dezembro";
                    break;
            }
            Console.WriteLine(c + "," + d + " de " + mes + " de " + a);
            Console.ReadKey();


        }
    }
}
