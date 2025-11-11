namespace Heranca
{
    public class Carro : Veiculos
    {
        public int NumeroDePortas { get; set; }

        public override void MostrarInfo()
        {
            Console.WriteLine($"Carro - Marca: {Marca}, Modelo: {Modelo}, Portas: {NumeroDePortas}");
        }
    }
}