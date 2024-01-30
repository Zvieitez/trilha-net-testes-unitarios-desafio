namespace TestesUnitarios.Desafio.Console.Services
{
    public class ValidacoesLista
    {   
        private static void VerificarListaNula(List<int> lista)
        {
            if (lista == null)
            {
                throw new ArgumentNullException("A lista não pode ser nula.", nameof(lista));
            }
        }

        public List<int> RemoverNumerosNegativos(List<int> lista)
        {
            VerificarListaNula(lista);

            return lista.Where(x => x > 0).ToList(); 
        }

        public bool ListaContemDeterminadoNumero(List<int> lista, int numero) 
        {
            VerificarListaNula(lista);

            return lista.Contains(numero);                                  
        }

        public bool NaoContemNumeroNaLista(List<int> lista, int numero)
        {
            VerificarListaNula(lista);

            return !lista.Contains(numero);
        }

        public List<int> MultiplicarNumerosLista(List<int> lista, int numero)
        {
            VerificarListaNula(lista);

            return lista.Select(x => x * numero).ToList();
        }

        public int RetornarMaiorNumeroLista(List<int> lista)
        {
            VerificarListaNula(lista);

            return lista.Max();
        }

        public int RetornarMenorNumeroLista(List<int> lista)
        {
            VerificarListaNula(lista);
            
            return lista.Min();
        }
    }
}
