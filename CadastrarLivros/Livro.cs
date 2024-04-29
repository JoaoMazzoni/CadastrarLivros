public class Livro
{
    Livro[] estante = new Livro[10];
    public string Titulo;
    public string Autor;
    public DateOnly Lancamento;
    public string Editora;
    public string Edicao;
    public int ISBN;
    public int Paginas;

    public Livro()
    {

    }


    public void definirTitulo(string titulo)
    {
        this.Titulo = titulo;
    }

    public void definirAutor(string autor)
    {
        this.Autor = autor;
    }

    public void definirLancamento(DateOnly data)
    {
        this.Lancamento = data;
    }

    public void definirEditora(string editora)
    {
        this.Editora = editora;
    }

    public void definirEdicao(string edicao)
    {
        this.Edicao = edicao;
    }

    public void definirISB(int isbn)
    {
        this.ISBN = isbn;
    }

    public void definirPaginas(int paginas)
    {
        this.Paginas = paginas;
    }

    public Livro criarLivro(Livro livro)
    {
        Livro livro1 = new Livro();

        Console.WriteLine("Insira o titulo do livro: ");
        livro.definirTitulo(Console.ReadLine());

        Console.WriteLine("Insira o autor do livro: ");
        livro.definirAutor(Console.ReadLine());

        Console.WriteLine("Insira a data de lançamento do livro: ");
        livro.definirLancamento(DateOnly.Parse(Console.ReadLine()));

        Console.WriteLine("Insira a editora do livro: ");
        livro.definirEditora(Console.ReadLine());

        Console.WriteLine("Insira a edição do livro: ");
        livro.definirEdicao(Console.ReadLine());

        Console.WriteLine("Insira o número do ISBN do livro: ");
        livro.definirISB(int.Parse(Console.ReadLine()));

        Console.WriteLine("Insira a quantidade de páginas do livro: ");
        livro.definirPaginas(int.Parse(Console.ReadLine()));

        return livro;
    }

    public void inserirLivros()
    {
        for (int i = 0; i < 10; i++)
        {
            estante[i] = criarLivro(this);
        }
    }

    public void imprimirLivros()
    {
        Console.WriteLine("\n----- INFORMAÇÕES DO LIVRO ----\n");
        Console.WriteLine("Título: {0}", this.Titulo);
        Console.WriteLine("Autor(es): {0}", this.Autor);
        Console.WriteLine("Data de Lançamento: {0}", this.Lancamento);
        Console.WriteLine("Editora: {0}", this.Editora);
        Console.WriteLine("Edição: {0}", this.Edicao);
        Console.WriteLine("ISBN: {0}", this.ISBN);
        Console.WriteLine("Quantidade de Páginas: {0}", this.Paginas);
    }


    public void imprimirPosicao(int posicao)
    {

        Console.WriteLine("Digite o número da posição de um livro: ");
        posicao = int.Parse(Console.ReadLine());
        estante[posicao] = new Livro();
        estante[posicao].imprimirLivros();
    }

}
