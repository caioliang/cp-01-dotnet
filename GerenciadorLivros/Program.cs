using static GerenciadorLivros.Lib.Gerenciador;


class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema de Cadastro de Livros");

            // Criando instâncias de livros
            var book1 = new Livro("1984", "George Orwell", 29.99);
            var book2 = new Livro("Dom Casmurro", "Machado de Assis", 19.99);

            book1.DisplayInfo();
            book2.DisplayInfo();

        }
    }

