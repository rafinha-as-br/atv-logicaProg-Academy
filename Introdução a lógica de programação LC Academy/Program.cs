//cria as variáveis
string texto;
int vogais=0, consoantes=0, palavras = 0;

//pede entrada de dados do usuário e armazena na variável texto
Console.WriteLine("Digite um texto: ");
texto = Console.ReadLine();

//loop que percorre a string texto e vai obtendo todas as informações
for (int i = 0; i < texto.Length; i++)
{
    //verifica os espaços
    if (texto[i] == ' ')
    {
        palavras++;
    }

    //verifica se é vogal ou consoante
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
Console.WriteLine("Quantidade de palavras: " + (palavras + 1));






