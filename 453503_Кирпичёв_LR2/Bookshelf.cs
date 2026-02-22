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
            _bookDescriptions.Add(bookDescription);
            Console.WriteLine($"Книга '{bookDescription}' размещена на полке {ShelfNumber}");
        }

        public void RemoveBook(string bookDescription)
        {
            if (_bookDescriptions.Remove(bookDescription))
            {
                Console.WriteLine($"Книга '{bookDescription}' убрана с полки {ShelfNumber}");
            }
        }

        public List<string> GetBookDescriptions()
        {
            return new List<string>(_bookDescriptions);
        }

        public void ListBooksOnShelf()
        {
            Console.WriteLine($"Книги на полке {ShelfNumber} (секция '{Section}'):");
            foreach (var desc in _bookDescriptions)
            {
                Console.WriteLine($"- {desc}");
            }
        }
    }
}