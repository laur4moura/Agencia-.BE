namespace Heranca
{
    public class Professor : Pessoa
    {
        public string Disciplina;

        public void MostrarInfo()
        {
            Console.WriteLine($"Professor: {Nome}, Idade: {Idade}, Disciplina: {Disciplina}");
        }
    }
}