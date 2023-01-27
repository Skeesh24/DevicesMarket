using DevicesMarket.Domain.Entities;

namespace DevicesMarket.Domain.Repositories.EntityFramework
{
    public class TextFieldsRepository
    {
        private readonly AppDbContext _context;

        public TextFieldsRepository(AppDbContext context)
        {
            _context = context;
        }
        public TextField GetProductById(Guid productId)
        {
            return _context.TextFields.FirstOrDefault(x => x.Id == productId);
        }

        public TextField GetProductByName(string productName)
        {
            return _context.TextFields.FirstOrDefault(x => x.Title == productName);
        }

        public IEnumerable<TextField> GetProducts()
        {
            return _context.TextFields;
        }

        public void SaveProduct(TextField entity)
        {
            if (entity.Id != default)
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
            _context.TextFields.Remove(new TextField() { Id = productId });
            _context.SaveChanges();
        }

    }
}
