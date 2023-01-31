namespace DevicesMarket.Models
{
    public class ContactsViewModel
    {
        public ContactsViewModel(int count)
        {
            this.count = count;
        }

        public int count { get; set; }

        public bool isNotEmpty => count > 0;
    }
}
