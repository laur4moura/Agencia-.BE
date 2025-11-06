namespace PrimeiraClasse
{
    public class Moto
    {
        //propriedades
        public string marca = "";

        public string modelo = "";

        public string cor = "";

        public int qntdRodas;


        //métodos 

        public void Ligar()
        {
            System.Console.WriteLine($"Moto Ligada");
        }
        public void Acelerar()
        {
            System.Console.WriteLine($"Moto Acelerando");
        }
        public void Desligar()
        {
            System.Console.WriteLine($"Moto desligada");
        }
    }
}