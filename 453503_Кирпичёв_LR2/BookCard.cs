namespace _453503_Кирпичёв_LR2
{
    public class BookCard
    {
        public string BookDescription { get; private set; }
        public DateTime AddToLibraryDate { get; private set; }
        public double Price { get; private set; }
        private List<string> _readerFullNames;

        public BookCard(string bookDescription, DateTime addToLibraryDate, double price)
        {
            BookDescription = bookDescription;
            AddToLibraryDate = addToLibraryDate;
            Price = price;
            _readerFullNames = new List<string>();
            Console.WriteLine($"Создана карточка для книги '{BookDescription}'");
        }

        public void AddToHistory(string readerFullName)
        {
            if (IsReaderNotInHistory(readerFullName))
            {
                _readerFullNames.Add(readerFullName);
                NotifyReaderAdded(readerFullName);
            }
        }

        public List<string> GetReaderHistory()
        {
            return new List<string>(_readerFullNames);
        }

        public void ShowHistory()
        {
            Console.WriteLine(FormatBookHistory());
        }

        private bool IsReaderNotInHistory(string reader)
        {
            return !_readerFullNames.Contains(reader);
        }

        private void NotifyReaderAdded(string reader)
        {
            Console.WriteLine($"Читатель {reader} добавлен в историю книги '{BookDescription}'");
        }

        private string FormatBookHistory()
        {
            string result = $"История выдачи книги '{BookDescription}':";
            foreach (var readerName in _readerFullNames)
            {
                result += $"\n- {readerName}";
            }
            return result;
        }
    }
}