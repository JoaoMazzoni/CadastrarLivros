internal class Livro
{
    //DEFININDO ATRIBUTOS
    string Titulo;
    string Autor;
    DateOnly Lancamento;
    string Editora;
    int Edicao;
    string ISBN;
    int Paginas;

    //FAZENDO O CONSTRUTOR
    public Livro(string titulo, string autor, DateOnly lancamento, string editora, int edicao, string iSBN, int paginas)
    {
        Titulo = titulo;
        Autor = autor;
        Lancamento = lancamento;
        Editora = editora;
        Edicao = edicao;
        ISBN = iSBN;
        Paginas = paginas;
    }

    //MÉTODO PARA IMPRIMIR AS INFORMAÇÕES DO LIVRO
    public void imprimirLivro()
    {
        Console.WriteLine("\n\n---- INFORMAÇÕES DO LIVRO ----");
        Console.WriteLine("Título: " + this.Titulo);
        Console.WriteLine("Autor: " + this.Autor);
        Console.WriteLine("Data de Lançamento: " + this.Lancamento);
        Console.WriteLine("Editor: " + this.Editora);
        Console.WriteLine("Edição: " + this.Edicao);
        Console.WriteLine("ISBN: " + this.ISBN);
        Console.WriteLine("Quantidade de Páginas: " + this.Paginas);

    }


}