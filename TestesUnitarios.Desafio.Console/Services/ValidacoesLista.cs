namespace TestesUnitarios.Desafio.Console.Services
{
    public class ValidacoesLista
    {
        //Pega uma lista de números e retorna somente os positivos
        public List<int> RemoverNumerosNegativos(List<int> lista)
        {
            var listaSemNegativos = lista.Where(x => x > 0);
            return listaSemNegativos.ToList();
        }

        //Pega dois valores - 1° sendo a lista de numeros para verificar- 2° sendo o numero para se existe na 1° lista
        public bool ListaContemDeterminadoNumero(List<int> lista, int numero)
        {
            var contem = lista.Contains(numero);
            return contem;
        }

        //Pega dois valores - o 1° uma lista de números - 2° um numero pelo qual a 1° lista vai Multiplicar
        //Exemplo
        //lista = 1, 2, 3, 4 // numero = 2 // 
        //Retorna os resultados de:
        //1 x 2 / 2 x 2 / 3 x 2 / 4 x 2 
        public List<int> MultiplicarNumerosLista(List<int> lista, int numero)
        {
            var listaMultiplicada = lista.Select(x => x * numero).ToList();
            return listaMultiplicada;
        }

        //Pega uma lista de números e retorna o maior número
        public int RetornarMaiorNumeroLista(List<int> lista)
        {
            return lista.Max();
        }

        //Pega uma lista de números e retorna o menor número
        public int RetornarMenorNumeroLista(List<int> lista)
        {
            return lista.Min();
        }
    }
}
