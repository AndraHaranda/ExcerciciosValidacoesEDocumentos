namespace WebserviceViaCEP
{
    internal class CEPBase
    {

        private static string GetEndereco(string cep)
        {
            string url = "https://viacep.com.br/ws/" + cep + "/json/";
        }
    }
}