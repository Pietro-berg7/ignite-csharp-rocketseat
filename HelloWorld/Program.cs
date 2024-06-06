namespace HelloWorld;

class Program
{
    static void Main()
    {
        var matematica = new OperacoesMatematicas();

        var resultado = matematica.Adicionar(valor1: 2, valor2: 5);

        Console.WriteLine(resultado);
        Console.WriteLine(resultado.resultadoDaAdição);
        Console.WriteLine(resultado.autor);
    }
}