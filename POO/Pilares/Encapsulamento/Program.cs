using Encapsulamento;

public static class Program
{
    public static void Main()
    {
        Carro c1 = new Carro();

        c1.DefinirMarca("BMW");
        c1.DefinirModelo("Hatch");

        c1.Acelerar(50);
        c1.Acelerar(20);
        c1.Frear(30);
        c1.Frear(50);

        Console.WriteLine($"Marca do carro:  {c1.ObterMarca()}");
        Console.WriteLine($"Modelo do carro: {c1.ObterModelo()}");
        Console.WriteLine($"Velocidade atual: {c1.ObterVelocidade()} km/h");
    }
}