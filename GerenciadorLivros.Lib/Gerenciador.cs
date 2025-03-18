namespace GerenciadorLivros.Lib;

public class Gerenciador
{

    public class Livro
    {
        public string Title { get; set; }
        public string Author { get; set; }

        protected string Publisher { get; set; }

        internal int Edition { get; set; }

        protected internal string Summary { get; set; }

        private double Price { get; set; }

        private protected string Notes { get; set; }

        file string InternalCode { get; set; } = Guid.NewGuid().ToString();

        public Livro(string title, string author, double price)
        {
            Title = title;
            Author = author;
            Price = price;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}");
        }
    }
}
