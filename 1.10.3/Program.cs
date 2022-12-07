namespace AtribuicaoReduzida
{
    public class AtribuicaoReduzida
    {
        static void Main(string[] args)
        {
            int x = 5;
            Console.WriteLine("Valor de X: " + x.ToString());

            //Equivale a x=x-3;
            x -= 3;

            Console.WriteLine($"Novo valor de X: {x}");
            Console.ReadKey();
        }
    }
}