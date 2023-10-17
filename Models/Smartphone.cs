using System.Runtime.CompilerServices;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; set; } 
        public string IMEI { get; set; }
        public int Memoria { get; set; }

        public Smartphone(string numero, string imei, int memoria, string modelo)
        {
            Numero = numero;
            IMEI = imei;
            Memoria = memoria;
            Modelo = modelo;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}