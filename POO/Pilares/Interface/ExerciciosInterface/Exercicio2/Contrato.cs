using System.Diagnostics.Contracts;

namespace Exercicio2
{
    public class Contrato : IImprimivel
    {

        public string Contratante = "";

        public string PrestadorServico = "";

        public string TextoClasulas = "";

        public Contrato(string contratante, string contratada, string txtClausulas)
        {

            Contratante = contratante;
            PrestadorServico = contratada;
            TextoClasulas = txtClausulas;
        }




        public void Imprimir()
        {
            System.Console.WriteLine($@"
            Partes:
                Contratante: {Contratante}
                Contratada: {PrestadorServico}
                Cláusulas do Contrato:

                {TextoClasulas}
                --
            
            ");
        }
    }
}