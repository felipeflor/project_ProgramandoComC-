namespace OperadoresAtribuicao{
    public class Atribuicao
    {
        static void Main(string[] args)
        {
            int a = 3;
            Console.WriteLine($"O valor de A é: {a}");

            int b = a;
            Console.WriteLine($"O valor de B é: {b}");

            a = 5;
            Console.WriteLine($"Novo valor de A é: {a}");
            Console.WriteLine($"Valor de B: {b}");

            Console.ReadKey();
        }
    }

}