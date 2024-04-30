//VARIAVEIS GLOBAIS
int indice = 0;
int op = 0;


//CRIANDO O VETOR ESTANTE QUE UTILIZA A CLASSE LIVRO
Livro[] estante = new Livro[10]; 


//MÉTODO PARA CRIAR LIVROS
Livro cadastrarLivro()
{
    //VARIAVEIS LOCAIS
    string titulo, autor, editora, isbn;
    int edicao, paginas;
    DateOnly lancamento;

    Console.WriteLine("Informe o título do livro: ");
    titulo = Console.ReadLine();

    Console.WriteLine("Informe o autor do livro: ");
    autor = Console.ReadLine();

    Console.WriteLine("Informe a data de lançamento do livro: ");
    lancamento = DateOnly.Parse(Console.ReadLine());

    Console.WriteLine("Informe a editora do livro: ");
    editora = Console.ReadLine();

    Console.WriteLine("Informe a edição do livro: ");
    edicao = int.Parse(Console.ReadLine());

    Console.WriteLine("Informe o ISBN do livro: ");
    isbn = Console.ReadLine();

    Console.WriteLine("Informe a quantidade de páginas do livro: ");
    paginas = int.Parse(Console.ReadLine());

    return new(titulo, autor, lancamento, editora, edicao, isbn, paginas);
    //RETORNO DOS VALORES DA VARIAVEIS PARA O CONSTRUTOR DA CLASSE LIVRO

}


//LOOPING PARA CADASTRAR LIVROS USANDO DO WHILE 
do
{
    Livro livro = cadastrarLivro();
    estante[indice] = livro;
    indice++;
    Console.WriteLine("Deseja cadastrar um novo livro?");
    op = int.Parse(Console.ReadLine());

} while (op != 0 && indice < 10);


//LOOPING PARA IMPRIMIR LIVROS USANDO FOR
for(int i = 0; i <= i; i++)
{
    estante[i].imprimirLivro();
}


Console.ReadLine();