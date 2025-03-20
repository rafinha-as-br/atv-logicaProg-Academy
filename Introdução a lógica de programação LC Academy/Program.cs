//Questão 3

//cria as variáveis necessárias
int numero1, numero2, resultado;

//solicita a entrada dos números
Console.WriteLine("Digite o primeiro número: ");
numero1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo número: ");
numero2 = int.Parse(Console.ReadLine());

//realiza a subtração
resultado = numero1 - numero2;

//verifica se a subtração é negativa e transforma em positiva
if(resultado > 0)
{
    resultado = resultado * -1;
}

Console.WriteLine("O valor absoluto desta subtração é: " + resultado);
