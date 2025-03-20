//Exercício 9

//cria as variáveis
string texto;
int vogais=0, consoantes=0, palavras = 0, contador=0;

//pede entrada de dados do usuário e armazena na variável texto
Console.WriteLine("Digite um texto: ");
texto = Console.ReadLine();

//calcula o tamanho da string texto
foreach(char c in texto) { contador++;  };

//loop que percorre a string texto e vai obtendo todas as informações
for (int i = 0; i < contador; i++)
{
    //verifica os espaços para contabilizar as palavras
    if (texto[i] == ' ')
    {
        palavras++;
    }

    //verifica se é vogal ou consoante em maisculo
    else if (texto[i] == 'A' || texto[i] == 'E' || texto[i] == 'I' || texto[i] == 'O' || texto[i] == 'U')
    {
        vogais++;
    }
    //verifica se é vogal ou consoante em minusculo
    else if (texto[i] == 'a' || texto[i] == 'e' || texto[i] == 'i' || texto[i] == 'o' || texto[i] == 'u')
    {
        vogais++;
    }
    else
    {
        consoantes++;
    }
}

//imprime as informações
Console.WriteLine("Quantidade de vogais: " + vogais);
Console.WriteLine("Quantidade de consoantes: " + consoantes);
Console.WriteLine("Quantidade de letras: " + (vogais+consoantes));
//soma 1 para contar a última palavra
Console.WriteLine("Quantidade de palavras: " + (palavras + 1));






