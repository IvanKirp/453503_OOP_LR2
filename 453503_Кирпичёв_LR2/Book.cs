namespace _453503_Кирпичёв_LR2
{
    public class Book
    {
        public string Title { get; private set; }
        public string Author { get; private set; }
        public string BookDescription { get; private set; }
        public bool IsAvailable { get; private set; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
            BookDescription = $"{title}, {author}";
            IsAvailable = true;
            Console.WriteLine($"Создана книга: {BookDescription}");
        }

        public void SetAvailability(bool status)
        {
            if (HasStatusChanged(status))
            {
                IsAvailable = status;
                StatusChange(status);
            }
        }

        public string GetBookInfo()
        {
            return FormatBookInfo();
        }

        private bool HasStatusChanged(bool newStatus)
        {
            return IsAvailable != newStatus;
        }

        private void StatusChange(bool status)
        {
            Console.WriteLine($"Статус доступности книги '{BookDescription}' изменён на: {(status ? "доступна" : "недоступна")}");
        }

        private string FormatBookInfo()
        {
            return $"Книга: {BookDescription}, Доступна: {IsAvailable}";
        }
    }
}