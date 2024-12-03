using System.Security.Cryptography.X509Certificates;

namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public Iphone (string numero, string modelo, string imei, int memoria) 
        : base (numero, modelo, imei, memoria)
        {
            public override void InstalarAplicativo(string nomeApp)
        {
            throw new NotImplementedException();
        }
    }
    }
}