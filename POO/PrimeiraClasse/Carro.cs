namespace PrimeiraClasse
{
    public class Carro
    {
        //propriedades
        public int qtdRodas;

        public int qtdPortas;

        public string marca = "";

        public string modelo = "";

        public string cor = "";

        //métodos

        public void Acelerar()
        {
            System.Console.WriteLine($"Carro Acelerando");
        }

        public void Frear()
        {
            System.Console.WriteLine($"Carro Freando");
        }

        public void Ligar()
        {
            System.Console.WriteLine($"Carro Ligando");
        }

        public void Desligar()
        {
            System.Console.WriteLine($"Carro Desigando");
        }

    }
}