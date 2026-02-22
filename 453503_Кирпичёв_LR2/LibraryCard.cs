namespace _453503_Кирпичёв_LR2
{
    public class LibraryCard
    {
        public int CardNumber { get; private set; }
        public string ReaderFullName { get; private set; }
        public DateTime IssueDate { get; private set; }
        public DateTime ExpiryDate { get; private set; }

        public LibraryCard(int cardNumber, string readerFullName, DateTime issueDate)
        {
            CardNumber = cardNumber;
            ReaderFullName = readerFullName;
            IssueDate = issueDate;
            ExpiryDate = issueDate.AddYears(1);
            Console.WriteLine($"Оформлен читательский билет {CardNumber} для {ReaderFullName}");
        }

        public bool IsValid()
        {
            return DateTime.Now <= ExpiryDate;
        }

        public void CheckValidity()
        {
            if (IsValid())
            {
                Console.WriteLine($"Билет {CardNumber} для {ReaderFullName} действителен до {ExpiryDate.ToShortDateString()}");
            }
            else
            {
                Console.WriteLine($"Билет {CardNumber} для {ReaderFullName} просрочен");
            }
        }

        public void RenewCard()
        {
            ExpiryDate = DateTime.Now.AddYears(1);
            Console.WriteLine($"Билет №{CardNumber} для {ReaderFullName} продлён до {ExpiryDate.ToShortDateString()}");
        }
    }
}