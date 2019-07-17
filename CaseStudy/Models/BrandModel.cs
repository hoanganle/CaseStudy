using System.Collections.Generic;
using System.Linq;
namespace CaseStudy.Models
{
    public class BrandModel
    {
        private AppDbContext _db;
        public BrandModel(AppDbContext ctx)
        {
            _db = ctx;
        }
        public List<Brands> GetAll()
        {
            return _db.Brands.ToList<Brands>();
        }
        public string GetName(int id)
        {
            Brands cat = _db.Brands.First(c => c.Id == id);
            return cat.Name;
        }
    }
}

