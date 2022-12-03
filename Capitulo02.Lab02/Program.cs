namespace Lab02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Informe a quantidade de dígitos da senha: ");
            int digitos = Convert.ToInt32(Console.ReadLine());

            if(digitos < 4 || digitos > 10 || digitos %2 != 0)
            {
                Console.WriteLine($"O valor {digitos} é" +
                    $"inválido de acordo com as regras.");
                Console.ReadKey();
                return;
            }

            string senha = "";

            //objeto a partir do qual os valores aleatórios serão gerados
            var rnd = new Random();

            for (int i = 0; i < digitos; i++)
            {
                //valor aleatório entre 0 e 9
                int numero = rnd.Next(0, 9);
                senha += numero;
            }
            Console.WriteLine($"Senha gerada: {senha}");
            Console.ReadKey();
        }
    }
}