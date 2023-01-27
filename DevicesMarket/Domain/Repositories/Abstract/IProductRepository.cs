using DevicesMarket.Domain.Entities;

namespace DevicesMarket.Domain.Repositories.Abstract
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        Product GetProductById(Guid productId);
        Product GetProductByName(string productName);
        void SaveProduct(Product entity);

        void DeleteProduct(Guid productId);
    }
}
