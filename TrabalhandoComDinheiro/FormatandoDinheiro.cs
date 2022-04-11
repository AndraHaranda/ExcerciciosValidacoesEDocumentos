using Caelum.Stella.CSharp.Vault;
using System.Diagnostics;
using System.Globalization;

namespace TrabalhandoComDinheiro
{
    internal class FormatandoDinheiro
    {
        static void Main(string[] args)
        {
            //Estrutura money

            Money money = 10.00;
            Debug.WriteLine(money); //Retorna o R$10,00

            //Soma 
            double valor1 = 10.00;
            double valor2 = 20.00;
            Money total = valor1 + valor2;
            Debug.WriteLine(total);

            //Subtração
            decimal minuendo = 20m; // m minúsculo simboliza o decimal
            decimal subtraendo = 15m;
            Money diferenca = minuendo - subtraendo;
            Debug.WriteLine(diferenca);

            Money euro = new Money(Currency.EUR, 1000);
            Debug.WriteLine(euro);
            Money dolar = new Money(Currency.USD, 1000);
            Debug.WriteLine(dolar);
            
            //Cultura da Thread 
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
            Debug.WriteLine(dolar);

            //A classe money possui proteção que impede a operacao entre moedas diferentes
            Money somaMoedasDiferenfes = euro + dolar;
            Debug.WriteLine(somaMoedasDiferenfes);

        }

    }
}
