int numero, resultado=0;

Console.WriteLine("Digite um número: ");
numero = int.Parse(Console.ReadLine());

for(int i=1; i <=9; i++)
{
    resultado = numero * i;
    Console.WriteLine($"{numero} x {i} = {resultado}");
}
