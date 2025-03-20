//Questão 6

//cria as variáveis necessárias
double cat1, cat2;
double hipotenusa;

//entrada de dados
Console.WriteLine("Digite o valor do cateto 1: ");
cat1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor do cateto 2: ");
cat2 = int.Parse(Console.ReadLine());

//calculo da hipotenusa (processamento)
hipotenusa = Math.Sqrt((cat1 * cat1) + (cat2 * cat2));

//impressão do resultado
Console.WriteLine("O valor da hipotenusa é: " + hipotenusa);