namespace _453503_Кирпичёв_LR2
{
    public class Subscription
    {
        public string SubscriptionType { get; private set; }
        public int DurationDays { get; private set; }
        public int MaxBooks { get; private set; }
        public double Price { get; private set; }

        public Subscription(string subscriptionType, int durationDays, int maxBooks, double price)
        {
            SubscriptionType = subscriptionType;
            DurationDays = durationDays;
            MaxBooks = maxBooks;
            Price = price;
            Console.WriteLine($"Создан абонемент: {SubscriptionType}");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Абонемент '{SubscriptionType}': на {DurationDays} дней, макс. книг: {MaxBooks}, цена: {Price} руб.");
        }
    }
}