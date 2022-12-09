using System.Collections;

namespace stack
{
    public class Program
    {
        static void Main(string[] args)
        {
            // é uma lista de objetos do tipo "pilha de pratos"
            // último que entra é o primeiro que sai
            // LIFO (Last-in first-out)
            // não possui indexador
            /*
            * Adicionar elemento no topo da pilha
            * pilha.Push( objeto );
            * Retirar elemento do topo da pilha
            * pilha.Pop();
            * Consultar o elemento no topo da pilha
            * pilha.Peek();
            */

            //Definir o objeto Stack
            Stack pilha = new Stack();

            //Adicionando itens à pilha
            pilha.Push("régua");
            pilha.Push("lápis");
            pilha.Push("borracha");
            pilha.Push("apontador");
            pilha.Push("estojo");

            //Exibindo os dados da pilha na listbox
            foreach (object i in pilha)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(new string('-', 30));

            //Exibindo o primeiro item da pilha
            Console.WriteLine("Primeiro item da pilha: " + pilha.Peek());
            Console.WriteLine(new string('-', 30));

            //Removendo o primeiro item da pilha
            pilha.Pop();

            //Exibindo o primeiro item da pilha depois do POP
            Console.WriteLine("Primeiro item da pilha depois do POP: " + pilha.Peek());
            Console.WriteLine(new string('-', 30));


            // Se tentarmos retirar um elemento da pilha e ela
            // estiver vazia, ocorrerá um erro
            if (pilha.Count > 0)
            {
                // Retira o primeiro elemento da pilha e retorna
                // com o seu conteúdo
                Console.WriteLine("Item removido da pilha: " + pilha.Pop());
                Console.WriteLine(new string('-', 30));
                //Exibindo os dados da pilha na listbox sem o item removido
                foreach (object i in pilha)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine(new string('-', 30));
            }


            Console.ReadKey();
        }
    }
}