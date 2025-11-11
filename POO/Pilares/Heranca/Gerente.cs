namespace Heranca
{
    public class Gerente : Funcionario
    {

        public double Bonus;

        public double CalcularSalario()
        {
            return SalarioBase + Bonus;
        }
        

    }
}

