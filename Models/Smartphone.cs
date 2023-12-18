namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero {get; set;}
        public string Modelo {get; set;}
        protected string IMEI {get; set;}
        protected int Memoria {get; set;}

        public Smartphone(string numeroInicial, string modeloInicial, string imeiInicial, int memoriaInicial)
        {
            Numero = numeroInicial;
            Modelo = modeloInicial;
            IMEI = imeiInicial;
            Memoria = memoriaInicial;
        }

        protected Smartphone(string numero)
        {
            Numero = numero;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public string ChecaMemoria() {
            return "O espaço de memória atual é de: " + Memoria;
        }

        public abstract void InstalarAplicativo(string nomeApp, int memoriaApp);
    }
}