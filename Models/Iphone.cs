namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia (string numero, string modelo, string imei, int memoria) : base(numero,modelo,imei, memoria)
        {

        }
        // Implementação do metodo abstrato/Sobrescrevi o metodo InstalarAplicativo
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp}...");
        }
    }

}