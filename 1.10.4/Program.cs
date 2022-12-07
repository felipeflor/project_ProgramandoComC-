namespace IncrementoDecremento
{
    public class IncrementoDecremento
    {
        static void Main(string[] args)
        {
            int a = 5;
            Console.WriteLine("Exemplo Pré-Incremental");
            Console.WriteLine("Valor de A: " + a);
            Console.WriteLine("2 + ++a = " + (2 + ++a));
            Console.WriteLine("Valor de A: " + a);
            Console.WriteLine(new string('-', 50));

            a = 5;
            Console.WriteLine("Exemplo Pós-Incremental");
            Console.WriteLine("Valor de A: " + a);
            Console.WriteLine("2 + a++ = " + (2 + ++a));
            Console.WriteLine("Valor de A: " + a);
            Console.WriteLine(new string('-', 50));

            a = 5;
            Console.WriteLine("Exemplo Pré-Decremental");
            Console.WriteLine("Valor de A: " + a);
            Console.WriteLine("2 + --a = " + (2 + --a));
            Console.WriteLine("Valor de A: " + a);
            Console.WriteLine(new string('#', 50));

            a = 5;
            Console.WriteLine("Exemplo Pós-Decremental");
            Console.WriteLine("Valor de A: " + a);
            Console.WriteLine("2 + a-- = " + (2 + a--));
            Console.WriteLine("Valor de A: " + a);
            Console.WriteLine(new string('#', 50));

            Console.ReadKey();

        }
    }
}