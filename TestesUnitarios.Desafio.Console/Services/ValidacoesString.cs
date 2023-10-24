namespace TestesUnitarios.Desafio.Console.Services
{
    public class ValidacoesString
    {

        //Pega um Texto e retorna a qualidade de letras que possui
        public int RetornarQuantidadeCaracteres(string texto)
        {
            var numeroCaracteres = texto.Length;
            return numeroCaracteres;
        }

        //Pega um texto (string texto), uma palavra (string textoProcurado) e verifica se o ´textoProcurado´ existe no ´texto´
        public bool ContemCaractere(string texto, string textoProcurado)
        {
            var contem = texto.Contains(textoProcurado);
            return contem;
        }

        //Pega um ´texto´ e um ´textoProcurado´ e verifica se o ´text´ terminar com ´textoProcurado´ funciona com uma só letra ou com uma palavra inteira
        public bool TextoTerminaCom(string texto, string textoProcurado)
        {
            var termina = texto.EndsWith(textoProcurado);
            return termina;
        }
    }
}