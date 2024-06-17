namespace HelloWorld;
public class Carro
{
    public string Modelo { get; set; }
    public DateOnly LancadoEm { get; set; }
    public Cor Cor { get; set; }

    public Carro(string modelo)
    {
        Modelo = modelo;
    }

    public void NomeDoModelo() => Console.WriteLine(Modelo);

    //public void Ligar()
    //{
    //    Console.WriteLine("Carro Ligado");
    //}

    //public void Desligar()
    //{
    //    Console.WriteLine("Carro Desligado");
    //}

    //private void Teste1()
    //{
    //    Console.WriteLine("Teste1");
    //}

    //internal void Teste2()
    //{
    //    Teste1();

    //    Console.WriteLine("Teste2");
    //}
}
