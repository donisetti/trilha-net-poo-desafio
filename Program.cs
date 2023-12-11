using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
class Program
{
    static void Main()
    {
        Console.WriteLine("criando iphone");
        Iphone iphone = new Iphone("753951", "iphone 14", "44555644", 64);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Facebook");

        Console.WriteLine("criando NOKIA");
        Nokia nokia = new Nokia("159753", "nokia XL", "789654", 128);

        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("ERP");


    }
}