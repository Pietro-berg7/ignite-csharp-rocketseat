using HelloWorld.Teste;
using System.Globalization;
using System.Text;

namespace HelloWorld;

class Program
{
    static void Main()
    {
        DateOnly dia = new DateOnly(2023, 12, 1);

        //string diaEmTexto = dia.ToLongDateString();
        string diaEmTexto = dia.ToString("dd/MMMM/yyyy", new CultureInfo("pt-BR"));

        DateTime dia1 = new DateTime(2023, 12, 1, 20, 07, 40);

        //DateTime hoje = DateTime.Now;
        //DateTime hoje = DateTime.Today;
        DateTime hoje = DateTime.UtcNow;

        DateTime novaData = hoje.AddDays(1);

        Console.WriteLine(novaData);
    }

    //static void Main()
    //{
    //    string texto1 = "Primeira frase.";
    //    string texto2 = "Segunda frase.";

    //    string paragrafo = texto1 + " " + 7 + " " + true + " " + texto2;

    //    string caminho = @"C:\teste"; // string caminho = "C:\\teste";

    //    string paragrafo2 = $"{texto1} {7} {true} {texto2}";

    //    StringBuilder stringBuilder = new StringBuilder();

    //    stringBuilder.Append(paragrafo);
    //    stringBuilder.Append(paragrafo2);

    //    string resultado = stringBuilder.ToString();

    //    string texto = "O usuário {0} gosta do número {1}.";
    //    string resultadoTexto = string.Format(texto, "Pietro", 7);

    //    Console.WriteLine(resultadoTexto);

    //}

    //static void Main()
    //{
    //    char letra = 'a';
    //    char numero = '1';
    //    char caracter = '@';
    //    char espaco = ' ';

    //    string texto = "string teste";
    //    char primeiraLetraDoTexto = texto[0];

    //    string nome = "          Pietro Bergamaschi           ";
    //    string nomeSemEspaco = nome.Trim();

    //    bool comecaComLetraP = nomeSemEspaco.StartsWith("P");
    //    bool terminaComLetraI = nomeSemEspaco.EndsWith("g");

    //    string textoAposReplace = nomeSemEspaco.Replace('e', '7');

    //    bool existe = texto.Contains("teste");
    //    bool igual = texto.Equals("teste");

    //    Console.WriteLine(existe);
    //    Console.WriteLine(igual);
    //}

    //static void Main()
    //{
    //    bool ativo = false;
    //    bool ativo2 = true;
    //}

    //static void main()
    //{
    //    // -2,147,483,648 to 2,147,483,647
    //    int numero = 1;

    //    // -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
    //    long numero2 = 2;

    //    // 0 to 4,294,967,295
    //    uint numero3 = 3;

    //    // -128 to 127
    //    sbyte numero4 = 127;

    //    // 0 to 255
    //    byte numero5 = 255;

    //    // ±5.0 × 10−324 to ±1.7 × 10308 | Precision ~15-17 digits	
    //    double numero6 = 3.14;

    //    // ±1.5 x 10−45 to ±3.4 x 1038 | Precision ~6-9 digits
    //    float numero7 = 0.14f;

    //    // ±1.0 x 10-28 to ±7.9228 x 1028 | Precision 28-29 digits
    //    decimal numero8 = 3.14m;

    //    Console.WriteLine(numero3);
    //}

    //static void Main()
    //{
    //    Carro meuCarro = new Carro();

    //    meuCarro.Ligar();

    //    meuCarro.Desligar();

    //    Biscoito meuBiscoito = new Biscoito();

    //    meuBiscoito.Temperatura();

    //    meuCarro.Teste2();
    //}
}