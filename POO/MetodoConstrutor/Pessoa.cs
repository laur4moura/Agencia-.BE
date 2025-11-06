namespace MetodoConstrutor
{
    public class Pessoa
    {
        public string Nome;
        public int Idade;
        
        //metodo construtor de pessoa
        /*possui parametros - representam os valores de nome e idade
        ou seja, estamos inicializando valores para as props
        ou seja, estamos inicializando valores para as props
        nome e idade*/
        public Pessoa(string n, int i)
        {
            Nome = n; //inicializa com valor de n
            Idade = i; //inicializa com valor de i
        }
        public void ExibirDados()
        {
            System.Console.WriteLine($"Nome: {Nome}");
        }
    }
}