namespace HelloWorld;

class Program
{
    enum Cores
    {
        Vermelho,
        Azul,
        Amarelo,
        Verde,
        Roxo
    }

    static void Main()
    {
        Cores cor = Cores.Roxo;

        switch (cor)
        {
            case Cores.Azul:
                {
                    Console.WriteLine("Azul");
                }
                break;
            case Cores.Vermelho:
                {
                    Console.WriteLine("Vermelho");
                }
                break;
            case Cores.Amarelo:
                {
                    Console.WriteLine("Amarelo");
                }
                break;
            default:
                {
                    Console.WriteLine("Outra cor");
                }
                break;
        }

        int numero = 7;

        string resultado = numero switch
        {
            >= 7 => "Pietro",
            1 => "Betotle",
            3 => "Bechote",
            _ => "Nome desconhecido"
        };

        Console.WriteLine(resultado);
    }
}