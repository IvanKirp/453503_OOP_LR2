namespace _453503_Кирпичёв_LR2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создаём библиотеку
            Library library = new Library("Библиотека имени Евгении Янищиц", "ул. Иркутско-Пинской дивизии, 35", "Главный каталог");

            //Создаём книги
            Book book1 = new Book("Война и мир", "Лев Толстой");
            Book book2 = new Book("Преступление и наказание", "Фёдор Достоевский");
            Book book3 = new Book("Мастер и Маргарита", "Михаил Булгаков");
            Book book4 = new Book("Евгений Онегин", "Александр Пушкин");

            Console.WriteLine();

            //Создаём каталог
            Catalog catalog = new Catalog("Главный каталог");
            catalog.AddBook(book1.BookDescription);
            catalog.AddBook(book2.BookDescription);
            catalog.AddBook(book3.BookDescription);
            catalog.AddBook(book4.BookDescription);

            Console.WriteLine();

            //Создаём библиотекарей
            Librarian librarian1 = new Librarian("Анна Петровна", "Главный библиотекарь");
            Librarian librarian2 = new Librarian("Елена Ивановна", "Библиотекарь абонемента");

            Console.WriteLine();

            //Нанимаем библиотекарей
            library.HireLibrarian(librarian1.FullName);
            library.HireLibrarian(librarian2.FullName);

            Console.WriteLine();

            //Создаём читателей
            Reader reader1 = new Reader("Иван Петров", "+375(44) 514-21-00");
            Reader reader2 = new Reader("Мария Сидорова", "+375(29) 325-67-64");

            Console.WriteLine();

            //Регистрируем читателей
            library.RegisterReader(reader1.FullName);
            library.RegisterReader(reader2.FullName);

            Console.WriteLine();

            //Оформляем читательские билеты
            LibraryCard card1 = new LibraryCard(1, reader1.FullName, DateTime.Now);
            LibraryCard card2 = new LibraryCard(2, reader2.FullName, DateTime.Now.AddMonths(-1));

            Console.WriteLine();

            //Создаём книжные полки и читальный зал
            Bookshelf shelf1 = new Bookshelf("Русская классика", 31);
            Bookshelf shelf2 = new Bookshelf("Русская классика", 32);
            ReadingRoom mainRoom = new ReadingRoom("Основной читальный зал", 50);

            mainRoom.AddBookshelf($"секция '{shelf1.Section}', полка {shelf1.ShelfNumber}");
            mainRoom.AddBookshelf($"секция '{shelf2.Section}', полка {shelf2.ShelfNumber}");
            library.AddReadingRoom(mainRoom.Name);

            Console.WriteLine();

            //Размещаем книги на полках
            shelf1.PlaceBook(book1.BookDescription);
            shelf1.PlaceBook(book2.BookDescription);
            shelf2.PlaceBook(book3.BookDescription);
            shelf2.PlaceBook(book4.BookDescription);

            Console.WriteLine();

            //Создаём карточки книг
            BookCard cardBook1 = new BookCard(book1.BookDescription, DateTime.Now.AddYears(-2), 500);
            BookCard cardBook2 = new BookCard(book2.BookDescription, DateTime.Now.AddYears(-1), 450);

            Console.WriteLine();

            //Создаём абонементы
            Subscription subscription1 = new Subscription("Стандартный", 30, 5, 0);
            Subscription subscription2 = new Subscription("Премиум", 100, 10, 500);

            Console.WriteLine("\nДемонстрация взаимодействия:\n");

            //Проверка каталога
            Console.WriteLine("Проверка наличия книг в каталоге:");
            Console.WriteLine($"Книга '{book3.BookDescription}' в каталоге: {catalog.ContainsBook(book3.BookDescription)}");
            Console.WriteLine($"Книга '{book1.BookDescription}' в каталоге: {catalog.ContainsBook(book1.BookDescription)}");

            Console.WriteLine();

            //Библиотекарь выдаёт книгу
            Console.WriteLine("Выдача книги:");
            librarian1.ProcessCheckout(reader1.FullName, book3.BookDescription);
            reader1.BorrowBook(book3.BookDescription);
            book3.SetAvailability(false);

            Console.WriteLine();

            //Читатель берёт ещё одну книгу
            Console.WriteLine("Читатель берёт ещё книгу:");
            librarian1.ProcessCheckout(reader1.FullName, book1.BookDescription);
            reader1.BorrowBook(book1.BookDescription);
            book1.SetAvailability(false);

            Console.WriteLine();

            //Проверка книг на руках у читателя
            reader1.ShowBorrowedBooks();

            Console.WriteLine();

            //Добавляем историю выдачи
            cardBook1.AddToHistory(reader1.FullName);

            Console.WriteLine();

            //Проверка читательского билета
            Console.WriteLine("Проверка билетов:");
            card1.CheckValidity();
            card2.CheckValidity();

            Console.WriteLine();

            //Читатель возвращает книгу
            Console.WriteLine("Возврат книги:");
            librarian2.ProcessReturn(reader1.FullName, book3.BookDescription);
            reader1.ReturnBook(book3.BookDescription);
            book3.SetAvailability(true);

            Console.WriteLine();

            //Просмотр книг на полке (по строкам "название, автор")
            shelf1.ListBooksOnShelf();

            Console.WriteLine();

            //Просмотр истории книги
            cardBook1.ShowHistory();

            Console.WriteLine();

            //Информация об абонементах
            subscription1.DisplayInfo();
            subscription2.DisplayInfo();

            Console.WriteLine();

            //Информация о библиотеке
            library.ShowLibraryInfo();
        }
    }
}