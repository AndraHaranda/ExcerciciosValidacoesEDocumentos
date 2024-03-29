﻿using Caelum.Stella.CSharp.Http;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebserviceViaCEP
{
    internal class CEP
    {
        static void Main(string[] args)
        {
            string cep = "010010007";
            string result = GetEndereco(cep);

            Debug.WriteLine(result);

            //Json
            ViaCEP viaCEP = new ViaCEP();
            string enderecoJson = viaCEP.GetEnderecoJson(cep);
            Debug.WriteLine(enderecoJson);

            //XML
            string enderecoXML = viaCEP.GetEnderecoXml(cep);
            Debug.WriteLine(enderecoXML);

            var task = viaCEP.GetEnderecoJsonAsync(cep);
            Debug.WriteLine(task.Result);

            var endereco = viaCEP.GetEndereco(cep);
            Debug.WriteLine(string.Format("Logradouro: {0}, Bairro: {1}", endereco.Logradouro, endereco.Bairro));
        }

        private static string GetEndereco(string cep)
        {
            string url = "https://viacep.com.br/ws/" + cep + "/json/"; //com xml vai sair xml

            string result = new HttpClient().GetStringAsync(url).Result;
            return result;
        }
    }
}
