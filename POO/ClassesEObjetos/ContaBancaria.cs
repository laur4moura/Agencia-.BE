namespace ClassesEObjetos
{
    public class ContaBancaria
    {
        public string titular = "";

        public double saldo;




        //método
        public void Depositar(double valor)
        {
            saldo += valor;
            System.Console.WriteLine($"Depósito de R${valor:f2} realizado! Saldo atual: R${saldo:f2}");
        }

        public void Sacar(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                System.Console.WriteLine($"Saque de R${valor:F2} realizado! Saldo atual: R${saldo:F2}");
            }
            else
            {
                System.Console.WriteLine("Saldo insuficiente para saque!");
            }
        }

    }
}


