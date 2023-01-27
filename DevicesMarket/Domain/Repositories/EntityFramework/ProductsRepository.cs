using DevicesMarket.Domain.Entities;
using DevicesMarket.Domain.Repositories.Abstract;

namespace DevicesMarket.Domain.Repositories.EntityFramework
{
    public class ProductsRepository : IProductRepository
    {
        private readonly AppDbContext _context;

        public ProductsRepository(AppDbContext context)
        {
            _context = context;
        }
        public Product GetProductById(Guid productId)
        {
            return _context.Products.FirstOrDefault(x => x.Id == productId);
        }

        public Product GetProductByName(string productName)
        {
            return _context.Products.FirstOrDefault(x => x.Title == productName);
        }

        public IEnumerable<Product> GetProducts()
        {
            return _context.Products;
        }

        public void SaveProduct(Product entity)
        {
            if(entity.Id != default)
            {
                _context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
            else
            {
                _context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            }
            _context.SaveChanges();
        }

        public void DeleteProduct(Guid productId)
        {
            _context.Products.Remove(new Product() { Id = productId });
            _context.SaveChanges();
        }

    }
}
