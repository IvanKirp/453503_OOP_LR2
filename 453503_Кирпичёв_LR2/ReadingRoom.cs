namespace _453503_Кирпичёв_LR2
{
    public class ReadingRoom
    {
        public string Name { get; private set; }
        public int Capacity { get; private set; }
        private List<string> _shelfDescriptions;

        public ReadingRoom(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            _shelfDescriptions = new List<string>();
            Console.WriteLine($"Открыт читальный зал '{Name}' вместимостью {Capacity} человек");
        }

        public void AddBookshelf(string shelfDescription)
        {
            _shelfDescriptions.Add(shelfDescription);
            Console.WriteLine($"В зал '{Name}' добавлена полка {shelfDescription}");
        }

        public List<string> GetShelfDescriptions()
        {
            return new List<string>(_shelfDescriptions);
        }

        public void ShowRoomInfo()
        {
            Console.WriteLine($"Зал '{Name}', вместимость: {Capacity}, полки: {string.Join(", ", _shelfDescriptions)}");
        }
    }
}