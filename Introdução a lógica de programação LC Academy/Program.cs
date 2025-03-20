float numero1, numero2;
int num1,num2, resultado;
Console.WriteLine("Digite o primeiro número: ");
numero1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo número: ");
numero2 = float.Parse(Console.ReadLine());

num1 = (int)Math.Round(numero1);
num2 = (int)Math.Round(numero2);

resultado = CalcularMMC(num1, num2); 

Console.WriteLine($"O MMC de {num1} e {num2} é {resultado}");

static int CalcularMMC(int a, int b)
{
    return (a * b) / CalcularMDC(a, b);
}
static int CalcularMDC(int a, int b)
{
    while (b != 0)
    {
        int temp = b;
        b = a % b;
        a = temp;
    }
    return a;
}