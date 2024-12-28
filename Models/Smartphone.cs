namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        
        public static string Modelo { get; set; }

        public static string IMEI { get; set; }

        public static int MemoriaInterna { get; set; }  

        public  List<string> AplicativosInstalados { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoriaInterna)
        {
            Numero = numero;

            Modelo = modelo;
            IMEI = imei;
            MemoriaInterna = memoriaInterna;

            AplicativosInstalados = new List<string>();
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