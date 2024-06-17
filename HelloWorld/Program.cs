namespace HelloWorld;

class Program
{
    static void Main()
    {
        //var carro = new Carro();

        //carro.Modelo = "Lamborghini";
        //carro.Cor = Cor.Vermelho;
        //carro.LancadoEm = new DateOnly(2021, 01, 01);

        var carro = new Carro("Lamborghini")
        {
            LancadoEm = new DateOnly(2021, 01, 01),
            Cor = Cor.Azul
        };


        carro.NomeDoModelo();

        /*
        var matematica = new OperacoesMatematicas();

        matematica.Teste(valor1: 2, valor2: 1);
        matematica.Teste(valor1: 2);
        */
    }
}