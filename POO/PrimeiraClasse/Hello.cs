namespace PrimeiraClasse
{
    public class Hello
    {

        //Propriedades que são características- Variaveis internas dessa classe
        public string TextoHello = "";

        //Métodos/Comportamentos/Ações- são as funções internas dessa classe
        public void SaudarUsuario()
        {
            Console.WriteLine(this.TextoHello);
        }

        public void SaudarComNome(string n)
        {
            System.Console.WriteLine($"Olá {n}");
        }
    }
}


