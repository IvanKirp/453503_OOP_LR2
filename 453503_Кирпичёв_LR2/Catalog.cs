namespace _453503_Кирпичёв_LR2
{
    public class Catalog
    {
        public string Name { get; private set; }
        private List<string> _bookDescriptions;

        public Catalog(string name)
        {
            Name = name;
            _bookDescriptions = new List<string>();
            Console.WriteLine($"Создан каталог: {Name}");
        }

        public void AddBook(string bookDescription)
        {
            _bookDescriptions.Add(bookDescription);
            Console.WriteLine($"Книга '{bookDescription}' добавлена в каталог {Name}");
        }

        public void RemoveBook(string bookDescription)
        {
            if (_bookDescriptions.Remove(bookDescription))
            {
                Console.WriteLine($"Книга '{bookDescription}' удалена из каталога {Name}");
            }
        }

        public bool ContainsBook(string bookDescription)
        {
            return _bookDescriptions.Contains(bookDescription);
        }

        public List<string> GetAllBookDescriptions()
        {
            return new List<string>(_bookDescriptions);
        }

        public void ShowAllBooks()
        {
            Console.WriteLine($"Все книги в каталоге {Name}:");
            foreach (var desc in _bookDescriptions)
            {
                Console.WriteLine($"- {desc}");
            }
        }
    }
}