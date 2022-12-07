namespace IfElse
{
    public class IfElse
    {
        static void Main(string[] args)
        {
            //Definir as variáveis
            int a;
            int b;
            //------------------------
            Console.WriteLine("Exemplo 1");
            a = 20;
            b = 100;
            //Como a condição é verdadeira, o texto será exibido
            if (a < b)
            {
                Console.WriteLine(a + " é menor que " + b);
            }
            Console.WriteLine(new string('-', 30));
            //------------------------
            Console.WriteLine("Exemplo 2");
            a = 20;
            b = 10;
            //Como a condição é falsa, o texto NÃO será exibido
            if (a < b)
            {
                Console.WriteLine(a + " é menor que " + b);
            }
            Console.WriteLine(new string('-', 30));
            //------------------------

            Console.WriteLine("Exemplo 3");
            a = 20;
            b = 10;
            //Como a condição é falsa, será exibido o texto do else
            if (a < b)
            {
                Console.WriteLine(a + " é menor que " + b);
            }
            else
            {
                Console.WriteLine(a + " é maior que " + b);
            }
            Console.WriteLine(new string('-', 30));
            //------------------------
            Console.WriteLine("Exemplo 4 - com erro");
            a = 20;
            b = 20;
            //Como a condição é falsa, será exibido o texto do else
            //que, nesse caso, será um erro
            if (a < b)
            {
                Console.WriteLine(a + " é menor que " + b);
            }
            else
            {
                Console.WriteLine(a + " é maior que " + b);
            }
            Console.WriteLine(new string('-', 30));
            //------------------------
            Console.WriteLine("Exemplo 4 - corrigido");
            a = 20;
            b = 20;
            //Para corrigir esta decisão 
            //precisaremos de mais uma comparação
            if (a < b)
            {
                Console.WriteLine(a + " é menor que " + b);
            }
            else if (a > b)
            {
                Console.WriteLine(a + " é maior que " + b);
            }
            else
            {
                Console.WriteLine(a + " é igual a " + b);
            }
            Console.WriteLine(new string('-', 30));
            Console.ReadKey();

        }
    }
}