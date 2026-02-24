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
            if (IsBookNotAdded(bookDescription))
            {
                _bookDescriptions.Add(bookDescription);
                BookAdded(bookDescription);
            }
        }

        public void RemoveBook(string bookDescription)
        {
            if (IsBookExists(bookDescription))
            {
                _bookDescriptions.Remove(bookDescription);
                BookRemoved(bookDescription);
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
            Console.WriteLine(FormatAllBooksList());
        }

        private bool IsBookNotAdded(string book)
        {
            return !_bookDescriptions.Contains(book);
        }

        private bool IsBookExists(string book)
        {
            return _bookDescriptions.Contains(book);
        }

        private void BookAdded(string book)
        {
            Console.WriteLine($"Книга '{book}' добавлена в каталог {Name}");
        }

        private void BookRemoved(string book)
        {
            Console.WriteLine($"Книга '{book}' удалена из каталога {Name}");
        }

        private string FormatAllBooksList()
        {
            string result = $"Все книги в каталоге {Name}:";
            foreach (var desc in _bookDescriptions)
            {
                result += $"\n- {desc}";
            }
            return result;
        }
    }
}