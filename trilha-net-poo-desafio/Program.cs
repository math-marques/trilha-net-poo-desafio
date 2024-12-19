using DesafioPOO.Models;
class Program
{
    static void Main(string[] args)
    {
        Nokia meuNokia = new Nokia("12345", "Nokia 3310", 123456789, 16);
        meuNokia.Ligar();
        meuNokia.ReceberLigacao();
        meuNokia.InstalarAplicativo("WhatsApp");
    }
}
