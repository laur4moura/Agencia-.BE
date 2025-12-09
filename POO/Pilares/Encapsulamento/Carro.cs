namespace Encapsulamento
{
    public class Carro
    {
        public string Marca;
        
        public string Modelo;

        public int velocidadeAtual;

        public void DefinirMarca (string valor)
        {
            Marca = valor;
        }

        public string ObterMarca()
        {
            return Marca;
        }

        public void DefinirModelo(string valor)
        {
            Modelo = valor;
        }

        public string ObterModelo()
        {
            return Modelo;
        }

        public int ObterVelocidade()
        {
            return velocidadeAtual;
        } 

        public void Acelerar(int valor)
        {
            if (valor >= 0)
            {
                velocidadeAtual += valor;
            }
        }

        public void Frear(int valor)
        {
            valor--;

            if (valor >= 0)
        {
            velocidadeAtual -= valor;
        } 
        else if (velocidadeAtual <= 0)
            {
                velocidadeAtual = 0;
            }
        }
        }
    }