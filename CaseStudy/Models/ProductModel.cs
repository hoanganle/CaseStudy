using System.Collections.Generic;
using System.Linq;
namespace CaseStudy.Models
{
    public class ProductModel
    {
        private AppDbContext _db;
        public ProductModel(AppDbContext context)
        {
            _db = context;
        }
        public List<Products> GetAll()
        {
            return _db.Products.ToList();
        }
        public List<Products> GetAllByCategory(int id)
        {
            return _db.Products.Where(item => item.Brand.Id == id).ToList();
        }
        public Brands GetCategory(int id)
        {
            return _db.Brands.FirstOrDefault(cat => cat.Id == id);
        }
    }
}