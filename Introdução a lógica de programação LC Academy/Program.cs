int[] numeros = new int[5];

for (int i = 0; i < 4; i++)
{
    Console.WriteLine("Digite um número:");
    numeros[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("\nNúmeros ímpares digitados:");
for (int i = 0; i < 4; i++)
{
    if (numeros[i] % 2 != 0)
    {
        Console.WriteLine(numeros[i]);
    }
}