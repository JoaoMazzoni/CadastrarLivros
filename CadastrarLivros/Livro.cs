internal class Livro
{
    //DEFININDO ATRIBUTOS
    string Titulo;
    Autor[] Autor; //Vetor de autores
    DateOnly Lancamento;
    string Editora;
    int Edicao;
    string ISBN;
    int Paginas;

    //FAZENDO O CONSTRUTOR
                          //Vetor de autores no construtor.
    public Livro(string titulo, Autor[] autores, DateOnly lancamento, string editora, int edicao, string iSBN, int paginas)
    {
        Titulo = titulo;
        Autor = autores; //Vetor |Autor| recebe os dados do vetor parâmetro construtor |autores|  
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
        Console.Write("Autores: ");

        Console.Write(Autor[0].getNome()); //Imprime obrigatoriamente o 1° Autor
        for (int i = 1; i < Autor.Length; i++) //Imprime os outros Autores, se houver.
        {
            Console.Write(", " + Autor[i].getNome()); // Imprime os nomes dos autores separados por vírgula
        }

        Console.WriteLine("\nData de Lançamento: " + this.Lancamento);
        Console.WriteLine("Editor: " + this.Editora);
        Console.WriteLine("Edição: " + this.Edicao);
        Console.WriteLine("ISBN: " + this.ISBN);
        Console.WriteLine("Quantidade de Páginas: " + this.Paginas);
    }

}

