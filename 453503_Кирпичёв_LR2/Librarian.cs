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
            Console.WriteLine($"Библиотекарь {FullName} оформляет выдачу книги '{bookDescription}' читателю {readerFullName}");
        }

        public void ProcessReturn(string readerFullName, string bookDescription)
        {
            Console.WriteLine($"Библиотекарь {FullName} принимает книгу '{bookDescription}' от читателя {readerFullName}");
        }

        public void AddNewBook(string title, string author)
        {
            Console.WriteLine($"Библиотекарь {FullName} добавляет новую книгу '{title}, {author}'");
        }
    }
}