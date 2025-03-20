//Questão 6

//Função que calcula a raiz de um número através da fórmula de newton (mesma fórmula da questão 5)
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

//cria as variáveis necessárias
double cat1, cat2;
double hipotenusa;

//entrada de dados
Console.WriteLine("Digite o valor do cateto 1: ");
cat1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor do cateto 2: ");
cat2 = int.Parse(Console.ReadLine());

//calculo da hipotenusa (processamento)
hipotenusa = calculaRaiz((cat1 * cat1) + (cat2 * cat2));
//converter o resultado para inteiro (pois o resultado é um double)
int hipotenusaInt = (int)hipotenusa;

//impressão do resultado
Console.WriteLine("O valor da hipotenusa é: " + hipotenusaInt);