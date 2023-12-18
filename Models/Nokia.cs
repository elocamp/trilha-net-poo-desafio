namespace DesafioPOO.Models {
    public class Nokia : Smartphone { 
        public Nokia(string numeroInicial, string modeloInicial, string imeiInicial, int memoriaInicial) : base(numeroInicial, modeloInicial, imeiInicial, memoriaInicial) {
            Numero = numeroInicial;
            Modelo = modeloInicial;
            IMEI = imeiInicial;
            Memoria = memoriaInicial;
        }

        public override void InstalarAplicativo(string nomeApp, int memoriaApp) {
            System.Console.WriteLine($"Instalando o aplicativo {nomeApp} no {Modelo}...");
            if (memoriaApp > Memoria) {
                System.Console.WriteLine("O espaço é insuficiente para instalar este aplicativo.");
            }
            else {
                System.Console.WriteLine("O aplicativo foi instalado com sucesso.");
                Memoria =- memoriaApp;
                ChecaMemoria();
            }
        }
    }
}