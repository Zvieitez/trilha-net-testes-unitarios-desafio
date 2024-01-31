namespace TestesUnitarios.Desafio.Console.Services
{
    public class ValidacoesLista
    {   
        public bool VerificarListaVazia(List<int> lista)
        {
            return lista.Count == 0;
        }

        public bool VerificarListaNula(List<int> lista)
        {
            return lista == null;
        }

        public List<int> RemoverNumerosNegativos(List<int> lista)
        {
            return lista.Where(x => x > 0).ToList(); 
        }

        public bool ListaContemDeterminadoNumero(List<int> lista, int numero) 
        {
            return lista.Contains(numero);                                  
        }

        public bool NaoContemNumeroNaLista(List<int> lista, int numero)
        {
            return !lista.Contains(numero);
        }

        public List<int> MultiplicarNumerosLista(List<int> lista, int numero)
        {
            return lista.Select(x => x * numero).ToList();
        }

        public int RetornarMaiorNumeroLista(List<int> lista)
        {
        return lista.Max();
        }

        public int RetornarMenorNumeroLista(List<int> lista)
        {   
        return lista.Min();
        }
    }
}
