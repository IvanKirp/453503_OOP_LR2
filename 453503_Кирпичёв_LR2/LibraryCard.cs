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
        }

        public bool IsValid()
        {
            return !IsExpired();
        }

        public void CheckValidity()
        {
            if (IsExpired())
            {
                Console.WriteLine($"Билет {CardNumber} для {ReaderFullName} просрочен");
            }
            else
            {
                Console.WriteLine($"Билет {CardNumber} для {ReaderFullName} действителен " +
                                $"ещё {GetDaysUntilExpiry()} дней");
            }
        }

        private bool IsExpired()
        {
            return DateTime.Now > ExpiryDate;
        }

        private int GetDaysUntilExpiry()
        {
            return (ExpiryDate - DateTime.Now).Days;
        }

        private string GetCardStatus()
        {
            return IsExpired() ? "просрочен" : "действителен";
        }
    }
}