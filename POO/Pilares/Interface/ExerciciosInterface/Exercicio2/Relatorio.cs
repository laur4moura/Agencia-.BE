namespace Exercicio2
{
    public class Relatorio : IImprimivel
    {

        public string Nome = "";

        public string TextoRelatorio = "";

        public Relatorio (string responsavel, string txtRelatorio)
        {
            Nome = responsavel;
            TextoRelatorio = txtRelatorio;
        }

        public void Imprimir()
        {
            System.Console.WriteLine($"Responsável: {Nome}...");
            System.Console.WriteLine(TextoRelatorio);
            System.Console.WriteLine($"----");
        }
    }
}