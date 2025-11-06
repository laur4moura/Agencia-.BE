namespace ClassesEObjetos
{
    public class GarrafaPet
    {
        public string material = "";

        public string cor = "";

        public double volume;

        public string nomeUsuario = "";

        //método

        public void Abrir()
        {
            System.Console.WriteLine($"garrafa está aberta");
        }
        public void Fechar()
        {
            System.Console.WriteLine($"garrafa está fechada");
        }
        public void Encher()
        {
            System.Console.WriteLine($"A garrafa está enchendo");
        }
         public void Esvaziar()
        {
            System.Console.WriteLine($"A garrafa está esvaziando");
        }
    }
}