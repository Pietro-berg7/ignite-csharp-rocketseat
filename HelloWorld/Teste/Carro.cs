namespace HelloWorld.Teste;
public class Carro
{
    public void Ligar()
    {
        Console.WriteLine("Carro Ligado");
    }

    public void Desligar()
    {
        Console.WriteLine("Carro Desligado");
    }

    private void Teste1()
    {
        Console.WriteLine("Teste1");
    }

    internal void Teste2()
    {
        Teste1();

        Console.WriteLine("Teste2");
    }
}
