int numero1, numero2, resultado;
Console.WriteLine("Digite o primeiro número: ");
numero1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo número: ");
numero2 = int.Parse(Console.ReadLine());

resultado = Math.Abs(numero2 - numero1);
Console.WriteLine("O valor absoluto desta subtração é: " + resultado);
