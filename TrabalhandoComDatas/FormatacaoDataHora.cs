using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhandoComDatas
{
    internal class FormatacaoDataHora
    {
        static void Main(string[] args)
        {
            //ToString é case sensitive e significa mm- é minuto e MM- mês
            DateTime data = new DateTime(2017, 9, 23);
            Debug.WriteLine(data);
            Debug.WriteLine(data.ToString("d")); //colocando somente o "d" em minúsculo, vai mostrar somente a data sem horas
            Debug.WriteLine(data.ToString("d", new CultureInfo("pt-BR"))); //Coloca o formato das horas padrão brasileiro
            Debug.WriteLine(data.ToString("dd/MM")); //dia e mês
            Debug.WriteLine(data.ToString("dd/MM/yy")); //dia, mês e ano


            //Formatação de data
            data = new DateTime(2017, 9, 23, 13, 14, 15, 987);
            Debug.WriteLine(data);
            Debug.WriteLine(data.ToString("hh:mm")); //Apresenta no formato americano quando está hh (ex: 01:14)
            Debug.WriteLine(data.ToString("HH:mm")); //Apresenta no formato brasileiro (ex: 13:14)
            Debug.WriteLine(data.ToString("HH:mm:ss:fff")); // retorna os segundos e milisegundos
        
            Debug.WriteLine(data.ToString("D")); // retorna a data por extenso (ex: sábado, 23 de setembro de 2017)
            Debug.WriteLine(data.ToString("m")); // retorna a data sem o ano (ex: 23 de setembro)
            Debug.WriteLine(data.ToString("Y")); // retorna somente o mês e ano (ex: setembro de 2017)
            Debug.WriteLine(data.ToString("G")); // retorna o formato completo (dia, mês, ano, hora, minuto, segundo)
            Debug.WriteLine(data.ToString("g")); // retira os segundos do formato completo
            Debug.WriteLine(data.ToString("O")); // Round-Trip(ida e volta), é utilizado para conversão de string para dateTime sem perda de conversão
            Debug.WriteLine(DateTime.Parse(data.ToString("O")).ToString("dd/MM/yyyy HH:mm:ss.fff"));
            Debug.WriteLine(data.ToString("t")); // retorno de hora e minuto
            Debug.WriteLine(data.ToString("T")); // retorno de hora, minuto e segundo
            
        
        
        }

    }
}
