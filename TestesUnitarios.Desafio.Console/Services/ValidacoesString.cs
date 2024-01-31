namespace TestesUnitarios.Desafio.Console.Services
{
    public class ValidacoesString
    {
        public int RetornarQuantidadeCaracteres(string texto)
        {
            return texto.Length;
        }

        public bool ContemTexto(string texto, string textoProcurado)
        {
            return texto.Contains(textoProcurado);
        }

        public bool TextoTerminaCom(string texto, string textoProcurado)
        {
            return texto.EndsWith(textoProcurado);
        }
    }
}