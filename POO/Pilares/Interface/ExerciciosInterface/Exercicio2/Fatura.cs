using System.Net.WebSockets;



namespace Exercicio2
{
    public class Fatura : IImprimivel
    {

        public string Devedor = "";

        public string Credor = "";

        public float Valor = 0;

        public int DiasDeAtraso = 0;

        private float Juros = 0.10f;


        public Fatura(string dev, string cre, float valFat, int qntdAtraso)
        {
            Devedor = dev;
            Credor = cre;
            Valor = valFat;
            DiasDeAtraso = qntdAtraso;
        }


        public void Imprimir()
        {


            CalcularValorDivida();

            System.Console.WriteLine($@"
                Credor: {Credor}
                Devedor: {Devedor}
                Dias de Atraso: {DiasDeAtraso} dia(s)
                Valor: R${Valor:10}
                Juros: R${(Juros * DiasDeAtraso):F2}
                Total Com Juros: R${Valor:F2}
            
            ");

            System.Console.WriteLine($"Credor: {Credor}...");
            System.Console.WriteLine($"Devedor: {Devedor}...");
            System.Console.WriteLine($"Dias de atraso: {DiasDeAtraso}...");
        }

        public void CalcularValorDivida()
        {
            if (DiasDeAtraso > 0)
            {
                Valor = Valor + DiasDeAtraso * Juros;
            }else if (DiasDeAtraso >= 5)
            {
                System.Console.WriteLine($"Divida encaminhada para o SERASA");
            }else{}
        }


    }
}
