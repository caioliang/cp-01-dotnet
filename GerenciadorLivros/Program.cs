using BookLibrary;

class Program
{
    static void Main(string[] args)
    {
        BookManager manager = new BookManager();
        string opcao;

        Console.WriteLine("Bem-vindo ao Sistema de Cadastro de Livros!");

        do
        {
            Console.WriteLine("\nSelecione uma opção:");
            Console.WriteLine("1 - Adicionar um livro");
            Console.WriteLine("2 - Alterar um livro");
            Console.WriteLine("3 - Remover um livro");
            Console.WriteLine("4 - Listar todos os livros");
            Console.WriteLine("0 - Sair");

            Console.Write("Digite a opção desejada: ");
            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Digite o título do livro: ");
                    string titulo = Console.ReadLine();

                    Console.Write("Digite o autor do livro: ");
                    string autor = Console.ReadLine();

                    Console.Write("Digite o preço do livro: ");
                    double preco;
                    while (!double.TryParse(Console.ReadLine(), out preco))
                    {
                        Console.Write("Preço inválido. Digite novamente: ");
                    }

                    manager.CreateBook(titulo, autor, preco);
                    break;

                case "2":
                    Console.Write("Digite o título do livro a ser alterado: ");
                    string tituloAntigo = Console.ReadLine();

                    Console.Write("Digite o novo título do livro: ");
                    string novoTitulo = Console.ReadLine();

                    Console.Write("Digite o novo autor do livro: ");
                    string novoAutor = Console.ReadLine();

                    Console.Write("Digite o novo preço do livro: ");
                    double novoPreco;
                    while (!double.TryParse(Console.ReadLine(), out novoPreco))
                    {
                        Console.Write("Preço inválido. Digite novamente: ");
                    }

                    manager.UpdateBook(tituloAntigo, novoTitulo, novoAutor, novoPreco);
                    break;

                case "3":
                    Console.Write("Digite o título do livro a ser removido: ");
                    string tituloParaRemover = Console.ReadLine();

                    manager.RemoveBook(tituloParaRemover);
                    break;

                case "4":
                    manager.ListBooks();
                    break;

                case "0":
                    Console.WriteLine("Encerrando o sistema... Até logo!");
                    break;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

        } while (opcao != "0");
    }
}