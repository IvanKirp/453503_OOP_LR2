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
            _borrowedBookDescriptions.Add(bookDescription);
            Console.WriteLine($"{FullName} взял книгу: {bookDescription}");
        }

        public void ReturnBook(string bookDescription)
        {
            if (_borrowedBookDescriptions.Remove(bookDescription))
            {
                Console.WriteLine($"{FullName} вернул книгу: {bookDescription}");
            }
        }

        public List<string> GetBorrowedBookDescriptions()
        {
            return new List<string>(_borrowedBookDescriptions);
        }

        public void ShowBorrowedBooks()
        {
            Console.WriteLine($"Книги на руках у {FullName}:");
            foreach (var desc in _borrowedBookDescriptions)
            {
                Console.WriteLine($"- {desc}");
            }
        }
    }
}