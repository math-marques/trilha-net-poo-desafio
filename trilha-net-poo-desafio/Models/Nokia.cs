namespace DesafioPOO.Models
{
   // Classe Nokia que herda de Smartphone
namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        // Construtor que chama o construtor da classe base
        public Nokia(string numero, string modelo, int imei, int memoria) 
            : base(numero)
        {
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        // Implementação do método abstrato da classe base
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia...");
        }
    }
}
        public override void InstalarAplicativo(string nomeApp)
        {
            throw new NotImplementedException();
        }
    }
}
