namespace ExercicioString01.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase: \n");
            string frase = Console.ReadLine();
            Console.WriteLine();

            string[] palavras = frase.Split(' ');
            for (int i = 0; i < palavras.Length; i++)
            {
                palavras[i] = palavras[i].Substring(0, 1).ToUpper() + palavras[i].Substring(1);
            }

            string novaFrase = string.Join(" ", palavras);

            Console.WriteLine("Frase com as primeiras letras maiúsculas: \n");
            Console.WriteLine(novaFrase);

        } 
    }
}