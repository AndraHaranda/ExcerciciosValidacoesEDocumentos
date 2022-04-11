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
    internal class ExcercioValidandoDoc
    {

        private void ValidarCPF(string cpf)
        {
            if (new CPFValidator().IsValid(cpf))
            {
                string ForamtarCPF = new CPFFormatter().Format(cpf);
                Debug.WriteLine(new CPFFormatter().Format(cpf));
                Debug.WriteLine("CPF válido " + cpf);
            }
            else
            {
                Debug.WriteLine("CPF inválido " + cpf);
            }
        }
        private void ValidarCNPJ(string cnpj)
        {
            if (new CNPJValidator().IsValid(cnpj))
            {
                string FormatarCNPJ = new CNPJFormatter().Format(cnpj);
                Debug.WriteLine(new CNPJFormatter().Format(cnpj));
                Debug.WriteLine("CNPJ válido");
            }
            else
            {
                Debug.WriteLine("CNPJ inválido");
            }
        }

        private void ValidarTitulo(string titulo)
        {
            if (new TituloEleitoralValidator().IsValid(titulo))
            {
                string FormatarTitulo = new TituloEleitoralFormatter().Format(titulo);
                Debug.WriteLine(new TituloEleitoralFormatter().Format(titulo));
                Debug.WriteLine("Titulo válido");
            }
            else
            {
                Debug.WriteLine("Titulo inválido");
            }
        }
    }
}
