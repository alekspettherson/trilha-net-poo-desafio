namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string imei, int memoria, string modelo) : base(numero, imei, memoria, modelo)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalado o aplicativo {nomeApp} no Nokia \n");
        }
    }
}