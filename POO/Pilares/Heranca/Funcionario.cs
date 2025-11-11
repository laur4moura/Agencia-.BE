namespace Heranca
{
    public class Funcionario
    {
        public string Nome;

        public int SalarioBase;

        public virtual double CalcularSalario()
        {
            return SalarioBase;
        }
    }
}
