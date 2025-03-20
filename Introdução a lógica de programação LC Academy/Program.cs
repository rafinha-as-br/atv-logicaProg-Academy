//Questão 2

//Cria a variável vetor de 5 posições
int[] numeros = new int[5];


//preenche o vetor com os números do usuário
for (int i = 0; i < 4; i++)
{
    Console.WriteLine("Digite um número:");
    numeros[i] = int.Parse(Console.ReadLine());
}


Console.WriteLine("\nNúmeros ímpares digitados:");

//verifica quais números são ímpares e imprime
for (int i = 0; i < 4; i++)
{
    if (numeros[i] % 2 != 0)
    {
        Console.WriteLine(numeros[i]);
    }
}