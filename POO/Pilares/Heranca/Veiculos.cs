namespace Heranca
{
    public class Veiculos
    {
        public string Marca;

        public string Modelo;

        public virtual void MostrarInfo()
        {
            System.Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}");
        }
    }
}