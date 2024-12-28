namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoriaInterna) : base(numero, modelo, imei, memoriaInterna)
        {

        }

        public override void InstalarAplicativo(string nomeApp)
        {
            AplicativosInstalados.Add(nomeApp);
        }
    }
}