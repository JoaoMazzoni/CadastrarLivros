//VARIAVEIS GLOBAIS
int indice = 0;
int op = 0;

//CRIANDO O VETOR ESTANTE QUE UTILIZA A CLASSE LIVRO
Livro[] estante = new Livro[10];

//CRIANDO FUNÇÃO - MENU
int Menu()
{
    Console.WriteLine("\n\n---- MENU ----");
    Console.WriteLine("1 - Cadastrar Livro");
    Console.WriteLine("2 - Imprimir Estante");
    Console.WriteLine("3 - Imprimir Livro");
    Console.WriteLine("4 - Sair");
    Console.Write("\nEscolha sua opção: ");

    return int.Parse(Console.ReadLine());
    //RETORNA O VALOR LIDO PARA FORA DA FUNÇÃO
}

//CRIANDO FUNÇÃO | CRIAR LIVROS
Livro cadastrarLivro()
{
    //VARIAVEIS LOCAIS
    string titulo, editora, isbn;
    int edicao, paginas;
    DateOnly lancamento;
    int qtdAutores = 0;

    Autor autor1 = new Autor(); // Instância para o primeiro autor
    Autor autor2 = new Autor(); // Instância para o segundo autor se for preciso
    Autor autor3 = new Autor();// Instância para o segundo autor se for preciso



    Console.WriteLine("\n|Informe o título do livro: ");
    titulo = Console.ReadLine();

    Console.Write("\n|Informe a quantidade de autores do livro: ");
    qtdAutores = int.Parse(Console.ReadLine());


    Console.WriteLine($"\n|Informe o nome do 1° autor do livro: ");
    autor1.setNome(Console.ReadLine());

    if (qtdAutores >= 2)
    {
        Console.WriteLine($"\n|Informe o nome do 2° autor do livro: ");
        autor2.setNome(Console.ReadLine());

        if (qtdAutores >= 3)
        {
            Console.WriteLine($"\n|Informe o nome do 3° autor do livro: ");
            autor3.setNome(Console.ReadLine());
        }

    }



    Console.WriteLine("\n|Informe a data de lançamento do livro: ");
    lancamento = DateOnly.Parse(Console.ReadLine());

    Console.WriteLine("\n|Informe a editora do livro: ");
    editora = Console.ReadLine();

    Console.WriteLine("\n|Informe a edição do livro: ");
    edicao = int.Parse(Console.ReadLine());

    Console.WriteLine("\n|Informe o ISBN do livro: ");
    isbn = Console.ReadLine();

    Console.WriteLine("\n|Informe a quantidade de páginas do livro: ");
    paginas = int.Parse(Console.ReadLine());

    return new(titulo, new Autor[] { autor1, autor2, autor3 }, lancamento, editora, edicao, isbn, paginas);
    //RETORNO DOS VALORES DA VARIAVEIS PARA CRIAR UM NOVO OBJETO EM SEU CONSTRUTOR.

}


//CRIANDO FUNÇÃO | LOOPING PARA CADASTRAR LIVROS USANDO DO WHILE 
void adicionarLivroNaEstante()
{

    Livro livro = cadastrarLivro();
    estante[indice] = livro;
    indice++;
    do
    {
        Console.WriteLine("\nDeseja cadastrar um novo livro?\n");
        Console.WriteLine("|1| - SIM");
        Console.WriteLine("|0| - NÃO");
        Console.Write("\nDigite sua opção: ");
        op = int.Parse(Console.ReadLine());

        if (op != 0 && indice < 10)
        {
            Console.Clear();
            Console.WriteLine("\n|Opção inválida!|\n");
        }

    } while (op != 0 && indice < 10);
}


//CRIANDO FUNÇÃO | LOOPING PARA IMPRIMIR LIVROS USANDO FOR
void imprimirEstante()
{
    for (int i = 0; i < indice; i++)
    {
        estante[i].imprimirLivro();
    }
}


//CRIANDO FUNÇÃO | IMPRIMIR UM LIVRO DE ACORDO COM O INDICE INFORMADO 
void buscarLivro(int i)
{
    estante[i - 1].imprimirLivro();
}


do
{
    switch (Menu())
    {
        case 1:
            adicionarLivroNaEstante();
            break;

        case 2:
            imprimirEstante();
            break;

        case 3:
            int posicao;
            do
            {
                Console.Write("Informe o índice do livro: ");
                posicao = int.Parse(Console.ReadLine());
                if (posicao > indice || posicao == 0)
                {
                    Console.WriteLine("\n|Não há livros cadastrados no índice informado|\n");
                }

            } while (posicao > indice || posicao == 0);

            buscarLivro(posicao);
            break;

        case 4:
            Environment.Exit(0);
            break;

        default:
            Console.WriteLine("\n|Opção inválida!|");
            break;
    }

} while (true);

//Vetor de autores