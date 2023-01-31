namespace DevicesMarket.Models
{
    public class RateViewModel
    {

        public RateViewModel(string name, string email, string message)
        {
            this.name = name;
            this.email = email;
            this.message = message;
        }

        public string name { get; set; }   
        
        public string email { get; set; }

        public string message { get; set; }

        public static List<RateViewModel> rates = new List<RateViewModel>();
    }
}