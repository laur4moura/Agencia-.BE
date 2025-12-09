using System.Diagnostics.Contracts;
using System.Dynamic;

namespace Encapsulamento
{
    public class ContaBancaria
    {
        public float Saldo;

        public ContaBancaria()
        {
            Saldo = 0;
        }

        public ContaBancaria(float saldoInicial)
        {
            if(saldoInicial >= 0)
            {
                Saldo = saldoInicial;
                return;
            }
        }

        public void Depositar(float valor)
        {
            if(valor >= 0)
            {
                Saldo = valor;
                return;
            }

            System.Console.WriteLine($"Valor para deposito invalido");
            
        }

        public float GetSaldo()
        {
            return Saldo;
        }

        public void Sacar(float valor)
        {
            if(valor >= 0 && valor <= Saldo)
            {
                Saldo -= valor;
                return;
            }

            System.Console.WriteLine($"Nao e possivel sacar este valor");
        }
    }
}