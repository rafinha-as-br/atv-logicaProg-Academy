//Questão 10

//criação das variáveis necessárias
    int quantidade, maiorNumero=0, MenorNumero=0, somaDosNumeros=0, somaNumerosPares=0, somaNumerosImpar=0;
    double mediaDosNumeros;

//entrada de dados da quantidade de números
    Console.WriteLine("Digite a quantidade de números que deseja informar: ");
    quantidade = int.Parse(Console.ReadLine());

//criação dos vetores com tamanho baseado na quantidade informada pelo usuário
    int[] numeros = new int[quantidade];
    int[] ordemCrescente = new int[quantidade];

//entrada de dados do vetor
    for (int i = 0; i < quantidade; i++)
    {
        Console.WriteLine($"Digite o {i + 1}º número: ");
        numeros[i] = int.Parse(Console.ReadLine());
        ordemCrescente[i] = numeros[i]; //copia os numeros para vetor cresce para ser utilizado na função posterior
    }


    maiorNumero = numeros[0];
    MenorNumero = numeros[0];
//verificação dos números maiores, menores, pares, impares e soma todos eles
for (int i=0; i<quantidade; i++) 
    {
        //coloca o primeiro numero como maior e menor para poder comparar com os demais


    
        if (numeros[i] > maiorNumero) //verifica se o número é maior 
        {
            maiorNumero = numeros[i];
   
        } else if (numeros[i] < MenorNumero)// verifica se o número é menor
        {
            MenorNumero = numeros[i];

        }


        if (numeros[i] % 2 == 0) //verifica se o número é par
        {
            somaNumerosPares += numeros[i];
        } else
        {
            somaNumerosImpar += numeros[i];
        } 

        //soma todos os números
        somaDosNumeros += numeros[i];

    }


//verificação da ordem crescente e decrescente usando o método bubble sort
    for (int i = 0; i < quantidade - 1; i++) 
    {
        for (int j = 0; j < quantidade - i - 1; j++) 
        {
            if (ordemCrescente[j] > ordemCrescente[j + 1]) 
            {
                int temp = ordemCrescente[j];
                ordemCrescente[j] = ordemCrescente[j + 1];
                ordemCrescente[j + 1] = temp;
            }
        }
    }


//calcula a média dos números
mediaDosNumeros = somaDosNumeros / quantidade;

//impressão de resultados:

    //impressão da ordem crescente
    Console.WriteLine("Ordem crescente: ");
    for(int i=0; i<quantidade; i++)
    {
        Console.Write($" {ordemCrescente[i]}");
    }
    //impressão da ordem decrescente

    Console.WriteLine("\nOrdem decrescente: ");
    for(int i=quantidade-1; i>=0; i--)
    {
        Console.Write($" {ordemCrescente[i]}");
    }
    //impressão do maior e menor numero
    Console.WriteLine($"\nO maior número é: {maiorNumero}");
    Console.WriteLine($"O menor número é: {MenorNumero}");
    //impressão da soma dos numeros
    Console.WriteLine($"A soma dos números é: {somaDosNumeros}");
    //impressão da soma dos números pares e impares
    Console.WriteLine($"A soma dos números pares é: {somaNumerosPares}");
    Console.WriteLine($"A soma dos números ímpares é: {somaNumerosImpar}");
    //impressão da média dos numeros;
    Console.WriteLine($"A média dos números é: {mediaDosNumeros}");

