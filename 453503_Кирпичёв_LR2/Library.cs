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
            _librarianNames.Add(librarianFullName);
            Console.WriteLine($"Библиотекарь {librarianFullName} принят на работу");
        }

        public void RegisterReader(string readerFullName)
        {
            _readerNames.Add(readerFullName);
            Console.WriteLine($"Читатель {readerFullName} зарегистрирован в библиотеке");
        }

        public void AddReadingRoom(string roomName)
        {
            _readingRoomNames.Add(roomName);
            Console.WriteLine($"В библиотеку добавлен читальный зал '{roomName}'");
        }

        public void ShowLibraryInfo()
        {
            Console.WriteLine($"\nИнформация о библиотеке '{Name}'");
            Console.WriteLine($"Адрес: {Address}");
            Console.WriteLine($"Сотрудники: {string.Join(", ", _librarianNames)}");
            Console.WriteLine($"Читатели: {string.Join(", ", _readerNames)}");
            Console.WriteLine($"Каталог: {CatalogName}");
            Console.WriteLine($"Читальные залы: {string.Join(", ", _readingRoomNames)}");
        }
    }
}