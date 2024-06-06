namespace HelloWorld;

class Program
{
    static void Main()
    {
        HashSet<int> set = new HashSet<int>();

        set.Add(1);
        set.Add(2);
        set.Add(3);
        set.Add(3); // Hashset não adiciona pois só pode receber valores únicos

        Console.WriteLine(set.Count);

        /*
        Dictionary<int, string> dicionario = new Dictionary<int, string>();

        dicionario.Add(1, "Hello");
        dicionario.Add(2, "World");
        dicionario.Add(7, "Betotle");
        //dicionario.Add(1, "Erro");

        string value = dicionario[2];
        bool existe = dicionario.ContainsKey(7);

        Console.WriteLine(existe);
        */

        /*
        List<string> strings = new List<string>();

        strings.Add("Hello");
        strings.Add("World");

        string resultado = string.Join(", ", strings);

        Console.WriteLine(resultado);
        */

        /*
        List<int> inteiros = new List<int>();

        inteiros.Add(1);
        inteiros.Add(2);
        inteiros.Add(3);

        //inteiros.Remove(1);
        //inteiros.RemoveAt(0);
        //inteiros.Clear();

        int primeiroElemento = inteiros.First();
        int ultimoElemento = inteiros.Last();
        int elementoSelecionado = inteiros.ElementAt(1);

        Console.WriteLine(primeiroElemento);
        Console.WriteLine(ultimoElemento);
        Console.WriteLine(elementoSelecionado);
        */

        /*
        int[] inteiros = new int[10];

        Console.WriteLine(inteiros.Length);

        inteiros[0] = 1;
        inteiros[1] = 10;
        inteiros[2] = 7;

        Console.WriteLine(inteiros[0]);
        Console.WriteLine(inteiros[1]);
        Console.WriteLine(inteiros[2]);

        int[] inteiros2 = [9, 8, 7];

        Console.WriteLine(inteiros2.Length);

        int[,] inteiros3 = new int[10, 10];
        int[,,] inteiros4 = new int[10, 10,10];

        inteiros3[0, 0] = 1;
        inteiros3[0, 3] = 2;

        Console.WriteLine(inteiros3[0, 0]);
        Console.WriteLine(inteiros3[0, 1]);
        Console.WriteLine(inteiros3[0, 2]);
        Console.WriteLine(inteiros3[0, 3]);
        */
    }
}