double cat1, cat2;
double hipotenusa;

Console.WriteLine("Digite o valor do cateto 1: ");
cat1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor do cateto 2: ");
cat2 = int.Parse(Console.ReadLine());

hipotenusa = Math.Sqrt((cat1 * cat1) + (cat2 * cat2));

Console.WriteLine("O valor da hipotenusa é: " + hipotenusa);