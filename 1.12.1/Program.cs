namespace StringFormat
{
    public class StringFormat
    {
        static void Main(string[] args)
        {
            string produto = "caneta";
            decimal preco = 6.32m;
            Console.WriteLine(string.Format("Produto: {0}\nPreco: {1}",
                produto, preco));

            //Formato monetário com duas casas pós vírgula
            //Respeita as configurações regionais do Windows
            string produto2 = "caneta";
            decimal preco2 = 6.32m;
            Console.WriteLine(string.Format("Produto: {0}\nPreço: {1:c2}", produto, preco));

            Console.ReadKey();
        }
    }
}