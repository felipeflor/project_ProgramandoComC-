namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal meuAnimal = new Animal();
            Animal meuPorco = new Porco();
            Animal meuCao = new Cao();

            meuAnimal.aminalSound();
            meuPorco.aminalSound();
            meuCao.aminalSound();

            Console.ReadKey();
        }
    }
}