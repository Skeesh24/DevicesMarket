using DevicesMarket.Domain.Entities;

namespace DevicesMarket.Domain.Repositories.Abstract
{
    public interface ITextFieldsRepository
    {
        public IEnumerable<TextField> GetTextFields();
        public TextField GetTextFieldById(Guid guid);

        public TextField GetTextField(string fieldName);
        
        void SaveProduct(Product entity);

        void DeleteProduct(Guid productId);
    }
}
