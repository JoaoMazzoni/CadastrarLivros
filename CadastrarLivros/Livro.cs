public class Livro
{
    int quantidade;
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

    public Livro criarLivro() //Método para criar livros com seus atributos.
    {
        Livro livro = new Livro();
        Console.WriteLine("--------------------------------------------------------");
        Console.WriteLine("\nInsira o titulo do livro: ");
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


    public void inserirLivros() //Repete o looping de criar livros, de acordo com a quantidade de livros
    {
        do
        {
            Console.Write("\n\n|Digite quantos livros deseja inserir: ");
            quantidade = int.Parse(Console.ReadLine());
            if (quantidade < 0 || quantidade > 10)
            {
                Console.WriteLine("\nValor inválido! \n| Mínimo: 1 livro | Máximo: 10 livros|\n");
            }
        } while (quantidade < 0 || quantidade > 10);

        for (int i = 0; i < quantidade; i++)
        {
            estante[i] = criarLivro(); //Usa função criar livros 
        }
    }

    public void imprimirInfo() //Estrutura de impressão das informações dos livros
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

    public void ImprimirLivros() //Imprime todos os livros 
    {
        for (int i = 0; i < estante.Length; i++)
        {
            if (estante[i] != null)
            {
                Console.WriteLine($"\n\n|Livro na posição {i + 1}|:");
                estante[i].imprimirInfo(); //Usa o método imprimirInfo
            }
        }
    }

    public void ImprimirPosicao()
    {
        Console.WriteLine("\nDigite o número da posição de um livro: ");
        int posicao = int.Parse(Console.ReadLine());
        if (posicao >= 1 && posicao <= quantidade)
        {
            Console.WriteLine($"Livro na posição {posicao}:");
            estante[posicao - 1].imprimirInfo();
        }
        else
        {
            Console.WriteLine("Posição inválida.");
        }
    }
}