namespace Heranca
{
    public class Moto : Veiculos
    {
        public string TipoCapacete { get; set; }

        public override void MostrarInfo()
        {
            Console.WriteLine($"Moto - Marca: {Marca}, Modelo: {Modelo}, Capacete: {TipoCapacete}");
        }
    }
}