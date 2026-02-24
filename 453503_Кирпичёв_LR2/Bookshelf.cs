namespace _453503_Кирпичёв_LR2
{
    public class Bookshelf
    {
        public string Section { get; private set; }
        public int ShelfNumber { get; private set; }
        private List<string> _bookDescriptions;

        public Bookshelf(string section, int shelfNumber)
        {
            Section = section;
            ShelfNumber = shelfNumber;
            _bookDescriptions = new List<string>();
            Console.WriteLine($"Добавлена полка {ShelfNumber} в секции '{Section}'");
        }

        public void PlaceBook(string bookDescription)
        {
            if (IsBookNotOnShelf(bookDescription))
            {
                _bookDescriptions.Add(bookDescription);
                BookPlaced(bookDescription);
            }
        }

        public void RemoveBook(string bookDescription)
        {
            if (IsBookOnShelf(bookDescription))
            {
                _bookDescriptions.Remove(bookDescription);
                BookRemoved(bookDescription);
            }
        }

        public List<string> GetBookDescriptions()
        {
            return new List<string>(_bookDescriptions);
        }

        public void ListBooksOnShelf()
        {
            Console.WriteLine(FormatBooksOnShelfList());
        }

        private bool IsBookNotOnShelf(string book)
        {
            return !_bookDescriptions.Contains(book);
        }

        private bool IsBookOnShelf(string book)
        {
            return _bookDescriptions.Contains(book);
        }

        private void BookPlaced(string book)
        {
            Console.WriteLine($"Книга '{book}' размещена на полке {ShelfNumber}");
        }

        private void BookRemoved(string book)
        {
            Console.WriteLine($"Книга '{book}' убрана с полки {ShelfNumber}");
        }

        private string FormatBooksOnShelfList()
        {
            string result = $"Книги на полке {ShelfNumber} (секция '{Section}'):";
            foreach (var desc in _bookDescriptions)
            {
                result += $"\n- {desc}";
            }
            return result;
        }
    }
}