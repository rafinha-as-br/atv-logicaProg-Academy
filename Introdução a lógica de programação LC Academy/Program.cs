float numero1, numero2, resultado;

Console.WriteLine("Informe o primeiro número decimal:");
numero1 = float.Parse(Console.ReadLine());
Console.WriteLine("Informe o segundo número decimal:");
numero2 = float.Parse(Console.ReadLine());

if (numero1 > numero2)
{
    resultado = numero1 / numero2;
    Console.WriteLine("O resultado da divisão do maior número pelo menor é: " + resultado);
}
else
{
    resultado = numero2 / numero1;
    Console.WriteLine("O resultado da divisão do maior número pelo menor é: " + resultado);
}