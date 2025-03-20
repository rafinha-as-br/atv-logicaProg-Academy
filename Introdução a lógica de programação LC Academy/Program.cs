//questão 4

//Função que calcula o MMC
static int CalcularMMC(int a, int b)
{
    return (a * b) / CalcularMDC(a, b);
}

//função que calcula o MDC (necessária para calcular o MMC)
static int CalcularMDC(int a, int b)
{
    //seguindo a fórmula de Euclides, enquanto b for diferente de 0, a recebe b e b recebe o resto da divisão de a por b
    while (b != 0)
    {

        int temp = b;
        b = a % b;
        a = temp;
    }
    return a;
}

//cria as variáveis de decimal e as inteiras
float numero1, numero2;
int num1,num2, resultado;

//entrada de numeros decimais
Console.WriteLine("Digite o primeiro número: ");
numero1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo número: ");
numero2 = float.Parse(Console.ReadLine());

//converte para inteiro
num1 = (int)Math.Round(numero1);
num2 = (int)Math.Round(numero2);

//calcula o MMC e coloca em uma variável para imprimir
resultado = CalcularMMC(num1, num2); 
//imprime o resultado 
Console.WriteLine($"O MMC de {num1} e {num2} é {resultado}");

