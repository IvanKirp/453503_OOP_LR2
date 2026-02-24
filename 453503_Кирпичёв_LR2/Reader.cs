namespace _453503_Кирпичёв_LR2
{
    public class Reader
    {
        public string FullName { get; private set; }
        public string Phone { get; private set; }
        private List<string> _borrowedBookDescriptions;

        public Reader(string fullName, string phone)
        {
            FullName = fullName;
            Phone = phone;
            _borrowedBookDescriptions = new List<string>();
            Console.WriteLine($"Зарегистрирован читатель: {FullName}");
        }

        public void BorrowBook(string bookDescription)
        {
            if (CanBorrowBook(bookDescription))
            {
                _borrowedBookDescriptions.Add(bookDescription);
                BookBorrowed(bookDescription);
            }
        }

        public void ReturnBook(string bookDescription)
        {
            if (CanReturnBook(bookDescription))
            {
                _borrowedBookDescriptions.Remove(bookDescription);
                BookReturned(bookDescription);
            }
        }

        public List<string> GetBorrowedBookDescriptions()
        {
            return new List<string>(_borrowedBookDescriptions);
        }

        public void ShowBorrowedBooks()
        {
            Console.WriteLine(FormatBooksList());
        }

        private bool CanBorrowBook(string book)
        {
            return !string.IsNullOrWhiteSpace(book);
        }

        private bool CanReturnBook(string book)
        {
            return _borrowedBookDescriptions.Contains(book);
        }

        private void BookBorrowed(string book)
        {
            Console.WriteLine($"{FullName} взял книгу: {book}");
        }

        private void BookReturned(string book)
        {
            Console.WriteLine($"{FullName} вернул книгу: {book}");
        }

        private string FormatBooksList()
        {
            string result = $"Книги на руках у {FullName}:";
            foreach (var desc in _borrowedBookDescriptions)
            {
                result += $"\n- {desc}";
            }
            return result;
        }
    }
}