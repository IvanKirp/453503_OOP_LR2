namespace _453503_Кирпичёв_LR2
{
    public class Library
    {
        public string Name { get; private set; }
        public string Address { get; private set; }
        public string CatalogName { get; private set; }
        private List<string> _librarianNames;
        private List<string> _readerNames;
        private List<string> _readingRoomNames;

        public Library(string name, string address, string catalogName)
        {
            Name = name;
            Address = address;
            CatalogName = catalogName;
            _librarianNames = new List<string>();
            _readerNames = new List<string>();
            _readingRoomNames = new List<string>();
            Console.WriteLine($"Библиотека '{Name}' открыта по адресу: {Address}\n");
        }

        public void HireLibrarian(string librarianFullName)
        {
            if (IsLibrarianNotHired(librarianFullName))
            {
                _librarianNames.Add(librarianFullName);
                LibrarianHired(librarianFullName);
            }
        }

        public void RegisterReader(string readerFullName)
        {
            if (IsReaderNotRegistered(readerFullName))
            {
                _readerNames.Add(readerFullName);
                ReaderRegistered(readerFullName);
            }
        }

        public void AddReadingRoom(string roomName)
        {
            if (IsRoomNotAdded(roomName))
            {
                _readingRoomNames.Add(roomName);
                RoomAdded(roomName);
            }
        }

        public void ShowLibraryInfo()
        {
            Console.WriteLine(FormatLibraryInfo());
        }

        private bool IsLibrarianNotHired(string librarian)
        {
            return !_librarianNames.Contains(librarian);
        }

        private bool IsReaderNotRegistered(string reader)
        {
            return !_readerNames.Contains(reader);
        }

        private bool IsRoomNotAdded(string room)
        {
            return !_readingRoomNames.Contains(room);
        }

        private void LibrarianHired(string librarian)
        {
            Console.WriteLine($"Библиотекарь {librarian} принят на работу");
        }

        private void ReaderRegistered(string reader)
        {
            Console.WriteLine($"Читатель {reader} зарегистрирован в библиотеке");
        }

        private void RoomAdded(string room)
        {
            Console.WriteLine($"В библиотеку добавлен читальный зал '{room}'");
        }

        private string FormatLibraryInfo()
        {
            return $"\nИнформация о библиотеке '{Name}'\n" +
                   $"Адрес: {Address}\n" +
                   $"Сотрудники: {string.Join(", ", _librarianNames)}\n" +
                   $"Читатели: {string.Join(", ", _readerNames)}\n" +
                   $"Каталог: {CatalogName}\n" +
                   $"Читальные залы: {string.Join(", ", _readingRoomNames)}";
        }
    }
}