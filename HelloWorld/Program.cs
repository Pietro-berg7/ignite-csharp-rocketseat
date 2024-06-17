namespace HelloWorld;

class Program
{
    enum Cores
    {
        Vermelho,
        Azul,
        Amarelo
    }

    static void Main()
    {
        int numero = 0;
        double saldo = 100.50;
        bool ativo = true;
        string autor = "Pietro";
        List<int> lista = new List<int> { 1, 7 };
        Cores cor = Cores.Azul;

        if (numero == 0 && (saldo > 100.0 || ativo))
        {
            Console.WriteLine("Entrou");
        }
    }
}