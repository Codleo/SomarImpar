public class Program
{
    public static void Main()
    {
        int soma = 0;

        for (int numero = 100; numero <= 200; numero++)
        {
            // Verifica se o número é ímpar
            if (numero % 2 != 0)
            {
                // Se for ímpar, adiciona à soma
                soma += numero;
            }
        }
        Console.WriteLine($"A soma dos números ímpares entre 100 e 200 é: {soma}");
    }
}