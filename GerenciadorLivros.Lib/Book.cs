using static GerenciadorLivros.Lib.Gerenciador;

namespace GerenciadorLivros.Lib
{

    public class Gerenciador
    {

        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }

            protected string Publisher { get; set; }

            internal int Edition { get; set; }

            protected internal string Summary { get; set; }

            private double Price { get; set; }

            private protected string Notes { get; set; }

            //file string InternalCode { get; set; } = Guid.NewGuid().ToString();

            public Book(string title, string author, double price, int edition, string summary)
            {
                Title = title;
                Author = author;
                Price = price;
                Edition = edition;
                Summary = summary;
            }

            public void DisplayInfo()
            {
                Console.WriteLine($"Title: {Title}, Author: {Author}");
            }
        }
    }
}
