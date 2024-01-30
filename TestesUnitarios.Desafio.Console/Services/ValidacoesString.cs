namespace TestesUnitarios.Desafio.Console.Services
{
    public class ValidacoesString
    {
        private static void VerificarFraseNula(string frase)
        {
            if (frase == null)
            {
                throw new ArgumentNullException(nameof(frase));
            }
        }

        public int RetornarQuantidadeCaracteres(string texto)
        {
            VerificarFraseNula(texto);

            return texto.Length;
        }

        public bool ContemTexto(string texto, string textoProcurado)
        {
            VerificarFraseNula(texto);
            VerificarFraseNula(textoProcurado);

            return texto.Contains(textoProcurado);
        }

        public bool TextoTerminaCom(string texto, string textoProcurado)
        {
            VerificarFraseNula(texto);
            VerificarFraseNula(textoProcurado);

            return texto.EndsWith(textoProcurado);
        }
    }
}