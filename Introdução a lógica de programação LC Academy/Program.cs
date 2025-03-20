float num;
int numero, resultado;

Console.WriteLine("Digite um número: ");
num = float.Parse(Console.ReadLine());
if (num < 0)
{
    Console.WriteLine("Não é possível fatorar números negativos");
}
else
{
    numero = (int)num;
    resultado = numero;
    for (int i=numero; i>1; i--)
    {
        resultado = resultado * (i-1);
    }

    Console.WriteLine("O fatorial de " + numero + " é " + resultado);
}