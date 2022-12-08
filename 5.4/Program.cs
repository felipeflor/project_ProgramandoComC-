using _5._4;

namespace herancaPolimorfismo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Produto prod = new Produto();
            prod.Nome = "Jatobá";
            prod.Preco = 6.47m;
            Console.WriteLine("PRODUTO\n" + prod.ExibirDados());
            //------------------
            Livro gibi = new Livro();
            gibi.Nome = "Soldado Invernal - Marcha da Amargura";
            gibi.Preco = 19.90m;
            gibi.NPaginas = 128;
            Console.WriteLine("LIVRO\n" + gibi.ExibirDados());


            Console.ReadKey();
        }
    }
}