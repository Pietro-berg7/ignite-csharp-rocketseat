namespace HelloWorld;

class Program
{
    static void Main()
    {
        var matematica = new OperacoesMatematicas();

        matematica.Adicionar(valor1: 2, valor2: 5);
        matematica.Subtrair(valor1: 1, valor2: 7);
    }
}