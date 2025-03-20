//Questão 7


//Cria as varíaveis necessárias
float num;
int numero, resultado;

//entrada de dados (numero decimal
Console.WriteLine("Digite um número: ");
num = float.Parse(Console.ReadLine());

//Verifica se o número é negativo
if (num < 0)
{
    Console.WriteLine("Não é possível fatorar números negativos");
}

else
{
    //Converte o número para inteiro
    numero = (int)num;
    //adiciona o primeiro número ao resultado (que será usado no loop abaixo)
    resultado = numero;
    //loop que calcula o fatorial
    for (int i=numero; i>1; i--)
    {
        resultado = resultado * (i-1);
    }

   //imprime o resultado
    Console.WriteLine("O fatorial de " + numero + " é " + resultado);
}