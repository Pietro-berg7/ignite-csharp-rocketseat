namespace HelloWorld;

class Program
{
    static void Main()
    {
        var numero = 10;

        do
        {
            Console.WriteLine("Teste");
            numero++;
        }
        while (numero < 10);

        Console.WriteLine(numero);

        //var numero = 0;

        //while (numero < 10)
        //{
        //    Console.WriteLine("Teste");
        //    numero++;
        //}

        //Console.WriteLine("Saiu");

        //var lista = new List<string> { "Pietro", "Betotle", "Bechote" };
        //var dicionario = new Dictionary<string, string>();

        //dicionario.Add("Nome1", "Pietro");
        //dicionario.Add("Nome2", "Betotle");
        //dicionario.Add("Nome3", "Bechote");

        //foreach (var item in dicionario)
        //{
        //    Console.WriteLine(item);
        //}

        //for (int i = 0; i < lista.Count; i++)
        //{
        //    Console.WriteLine($"{i + 1}: {lista[i]}");
        //}
    }
}