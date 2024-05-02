namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero,modelo,imei, memoria)
        {
            // Inicialização especi­fica, se necessario.
        }

        // Implementação do metodo abstrato/Sobrescrevi o metodo InstalarAplicativo
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp}...");
        }

    }

}