Livro livro = new Livro();
while (true)
{
    void Menu()
    {
        bool TrueFalse = false;
        int opcao = 0;
        do
        {

            Console.WriteLine("\n---- MENU ----");
            Console.WriteLine("\n|1| - Adicionar um Livro");
            Console.WriteLine("|2| - Imprimir a Estante");
            Console.WriteLine("|3| - Imprimir um Livro");
            Console.Write("\nEscolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

        } while (TrueFalse == true);

        switch (opcao)
        {
            case 1:
                livro.inserirLivros();
                break;

            case 2:
                livro.ImprimirLivros();
                break;

            case 3:
                livro.ImprimirPosicao();
                break;

            default:
                TrueFalse = true;
                Console.WriteLine("\n|Opcão inválida!");
                break;

        }
    }
    Menu();
    Console.ReadLine();
    Console.Clear();
}
