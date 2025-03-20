int a, b, c, x, x1,x2;
float resultado;
int delta;

Console.WriteLine("Digite o valor de A: ");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor de B: ");
b = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor de C: ");
c = int.Parse(Console.ReadLine());

delta = b* b - 4 * a * c;

if(delta > 0)
{
    x1 = (-b + (int)Math.Sqrt(delta)) / (2 * a);
    x2 = (-b - (int)Math.Sqrt(delta)) / (2 * a);
    Console.WriteLine("Trata-se de duas raízes, portanto: ");
    Console.WriteLine("O X1 é: " + x1);
    Console.WriteLine("O X2 é: " + x2);
} else if (delta == 0)
{
    x = -b / (2 * a);
    Console.WriteLine("Trata-se de uma raiz única, portanto o X é: " + x);

} else
{
    Console.WriteLine("Não existe raiz real");
}
