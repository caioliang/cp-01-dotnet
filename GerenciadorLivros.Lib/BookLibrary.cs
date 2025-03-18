using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;

using static GerenciadorLivros.Lib.Gerenciador; 

namespace BookLibrary
{
    public class BookManager
    {

        private List<Book> books = new List<Book>();

        public void CreateBook(string title, string author, double price, int edition, string summary)
        {
            var book = new Book(title, author, price, edition, summary);
            books.Add(book);
            Console.WriteLine($"Livro '{title}' adicionado com sucesso!");
        }

        public void UpdateBook(string oldTitle, string newTitle, string newAuthor, double newPrice)
        {
            var book = books.Find(b => b.Title.Equals(oldTitle, StringComparison.OrdinalIgnoreCase));
            if (book != null)
            {
                book.Title = newTitle;
                book.Author = newAuthor;
                Console.WriteLine($"Livro '{oldTitle}' atualizado para '{newTitle}'.");
            }
            else
            {
                Console.WriteLine($"Livro '{oldTitle}' não encontrado!");
            }
        }

        public void RemoveBook(string title)
        {
            var book = books.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (book != null)
            {
                books.Remove(book);
                Console.WriteLine($"Livro '{title}' removido com sucesso!");
            }
            else
            {
                Console.WriteLine($"Livro '{title}' não encontrado!");
            }
        }

        public void ListBooks()
        {
            Console.WriteLine("Lista de Livros:");
            foreach (var book in books)
            {
                book.DisplayInfo();
            }
        }
    }
}
