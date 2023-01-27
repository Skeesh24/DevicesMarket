using DevicesMarket.Domain.Repositories.Abstract;

namespace DevicesMarket.Domain
{
    public class DataManager
    {
        public ITextFieldsRepository textFieldsRepository { get; set; }
        public IProductRepository productRepository { get; set; }

        public DataManager(ITextFieldsRepository textFieldsRepository, IProductRepository productRepository)
        {
            this.textFieldsRepository = textFieldsRepository;
            this.productRepository = productRepository;
        }
    }
}
