namespace TestesUnitarios.Desafio.Console.Services
{
    public class ValidacoesString
    {
        private static void VerificarNulo(string frase)
        {
            if (frase == null)
            {
                throw new ArgumentNullException(nameof(frase));
            }
        }

        public int RetornarQuantidadeCaracteres(string texto)
        {
            VerificarNulo(texto);

            return texto.Length;
        }

        public bool ContemTexto(string texto, string textoProcurado)
        {
            VerificarNulo(texto);
            VerificarNulo(textoProcurado);

            return texto.Contains(textoProcurado);
        }

        public bool TextoTerminaCom(string texto, string textoProcurado)
        {
            VerificarNulo(texto);
            VerificarNulo(textoProcurado);

            return texto.EndsWith(textoProcurado);
        }
    }
}