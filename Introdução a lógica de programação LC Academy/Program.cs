//Questão 8

//cria as variavéis necessárias
int numero, resultado=0;

//entrada de dados 
Console.WriteLine("Digite um número: ");
numero = int.Parse(Console.ReadLine());

//realização e impressão do resultado (tabuada até o 9)
for(int i=1; i <=9; i++)
{
    resultado = numero * i;
    Console.WriteLine($"{numero} x {i} = {resultado}");
}
