using Caelum.Stella.CSharp.Format;
using Caelum.Stella.CSharp.Validation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidandoDocumento
{
    internal class ValidarDocumento
    {
        static void Main(string[] args)
        {
            string cpf = "86288366757";
            string cpf2 = "987453667297";
            string cpf3 = "22222222222";

            Debug.WriteLine(cpf);
            string cpfFormatado = new CPFFormatter().Format(cpf);
            Debug.WriteLine(cpfFormatado);
            Debug.WriteLine(new CPFFormatter().Format(cpfFormatado)); //Formata 
            Debug.WriteLine(new CPFFormatter().Unformat(cpfFormatado)); //Tira a formatação

            ////SE QUISER TRATAR COMO EXCEÇÃO 
            //try
            //{
            //    new CPFValidator().AssertValid(cpf); //AssertValid() serve para permitir que o programa continue se o CPF válido
            //    Debug.WriteLine("CPF válido " + cpf); //concatenação (soma de dois obj)
            //}
            //catch (Exception ex)
            //{
            //    Debug.WriteLine("CPF inválido " + cpf + ex.ToString());
            //}

            //FAZER COM BOOLEANA
            if (new CPFValidator().IsValid(cpf2))
            {
                Debug.WriteLine("CPF válido " + cpf2);
            }
            else
            {
                Debug.WriteLine("CPF inválido " + cpf2);
            }

            string cnpj = "51241758000152";
            string cnpj2 = "14128481000120";


            if (new CNPJValidator().IsValid(cnpj))
            {
                Debug.WriteLine("CNPJ válido");
            }
            else
            {
                Debug.WriteLine("CNPJ inválido");
            }

            string titulo1 = "041372570132";
            string titulo2 = "774387480132";

            if (new TituloEleitoralValidator().IsValid(cnpj2))
            {
                Debug.WriteLine("Titulo Eleitoral válido");
            }
            else
            {
                Debug.WriteLine("Titulo Eleitoral inváido");
            }
        }
    }
}

