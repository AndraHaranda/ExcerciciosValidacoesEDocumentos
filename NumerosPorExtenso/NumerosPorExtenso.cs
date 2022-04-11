using Caelum.Stella.CSharp.Inwords;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhandoComNumero
{
    internal class NumerosPorExtenso
    {
        static void Main(string[] args)
        {
            double valor = 75;
            string extenso = new Numero(valor).Extenso();
            Debug.WriteLine(extenso);

            valor = 1532987;
            extenso = new Numero(valor).Extenso();
            Debug.WriteLine(extenso);

            string extensoBRL = new MoedaBRL(valor).Extenso();
            Debug.WriteLine(extensoBRL);
            string extensoEUR = new MoedaEUR(valor).Extenso();
            Debug.WriteLine(extensoEUR);
            string extensoUSD = new MoedaUSD(valor).Extenso();
            Debug.WriteLine(extensoUSD);
        }
    }
}
