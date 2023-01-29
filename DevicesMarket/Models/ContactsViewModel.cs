namespace DevicesMarket.Models
{
    public class ContactsViewModel
    {
        public int? count { get; set; }
        public bool ? isNotEmpty => count > 0;
    }
}
