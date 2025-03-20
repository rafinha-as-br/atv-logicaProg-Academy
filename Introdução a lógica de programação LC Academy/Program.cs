//Questão 5

//Função que calcula a raiz de um número através da fórmula de newton 
static double calculaRaiz(double n)
{
    double x = n;
    double raiz = 0;
    while (true)
    {
        raiz = 0.5 * (x + n / x);
        if (Math.Abs(raiz - x) < 0.0001)
        {
            break;
        }
        x = raiz;
    }
    return raiz;
}


//Cria as variáveis necessárias
int a, b, c, x, x1,x2;
float resultado;
int delta;

//entrada de dados
Console.WriteLine("Digite o valor de A: ");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor de B: ");
b = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor de C: ");
c = int.Parse(Console.ReadLine());

//realiza o calculo de delta 
delta = b* b - 4 * a * c;

//verifica o valor de delta, realiza os cálculos de X1 e X2 (utilizando a função de calcular raiz) e já imprime os resultados
if(delta > 0) //se o delta for maior que 0, temos duas raízes
{
    x1 = (-b + (int)calculaRaiz(delta)) / (2 * a);
    x2 = (-b - (int)calculaRaiz(delta)) / (2 * a);
    Console.WriteLine("Trata-se de duas raízes, portanto: ");
    Console.WriteLine("O X1 é: " + x1);
    Console.WriteLine("O X2 é: " + x2);
} else if (delta == 0) //se delta for igual a 0, temos uma única raiz
{
    x = -b / (2 * a);
    Console.WriteLine("Trata-se de uma raiz única, portanto o X é: " + x);

} else //se delta for menor que 0, não existe raiz real
{
    Console.WriteLine("Não existe raiz real");
}
