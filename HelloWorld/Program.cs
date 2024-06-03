namespace HelloWorld;

class Program
{
    enum NivelDeDificuldade
    {
        Baixo = 0,
        Medio = 1,
        Alto = 2
    }

    static void Main()
    {
        int? idade = null;
        int? idade2 = 24;

        bool informouIdade = idade.HasValue;
        int idadeInformada = idade2.Value;

        Console.WriteLine(informouIdade);
        Console.WriteLine(idadeInformada);

        /*
        object minhaVariavel = new Carro();
        */

        /*
        string nome = "Pietro Bergamaschi";
        int meuNumero = 7;

        var nome2 = "Pietro Bergamaschi";
        var meuNumero2 = 7;

        var variavel = new Carro();
        var variavel2 = DateTime.Now;
        */

        /*
        NivelDeDificuldade nivel = NivelDeDificuldade.Alto;

        int nivelInteiro = (int)nivel;

        Console.WriteLine(nivel);
        Console.WriteLine(nivelInteiro);
        */
    }
}