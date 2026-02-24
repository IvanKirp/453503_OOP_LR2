namespace _453503_Кирпичёв_LR2
{
    public class Librarian
    {
        public string FullName { get; private set; }
        public string Position { get; private set; }

        public Librarian(string fullName, string position)
        {
            FullName = fullName;
            Position = position;
            Console.WriteLine($"Новый сотрудник: {FullName}, должность: {Position}");
        }

        public void ProcessCheckout(string readerFullName, string bookDescription)
        {
            FormatCheckoutMessage(readerFullName, bookDescription);
        }

        public void ProcessReturn(string readerFullName, string bookDescription)
        {
            FormatReturnMessage(readerFullName, bookDescription);
        }

        public void AddNewBook(string title, string author)
        {
            FormatAddBookMessage(title, author);
        }

        private void FormatCheckoutMessage(string reader, string book)
        {
            Console.WriteLine($"Библиотекарь {FullName} оформляет выдачу книги '{book}' читателю {reader}");
        }

        private void FormatReturnMessage(string reader, string book)
        {
            Console.WriteLine($"Библиотекарь {FullName} принимает книгу '{book}' от читателя {reader}");
        }

        private void FormatAddBookMessage(string title, string author)
        {
            Console.WriteLine($"Библиотекарь {FullName} добавляет новую книгу '{title}, {author}'");
        }
    }
}