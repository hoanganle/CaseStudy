using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
namespace CaseStudy.Models
{
    public class BrandViewModel
    {
        private List<Brands> _brands;
        public BrandViewModel() { }
        public string BrandName { get; set; }
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int Qty { get; set; }

        public IEnumerable<Products> Items { get; set; }
        public IEnumerable<SelectListItem> GetCategories()
        {
            return _brands.Select(category => new SelectListItem
            {
                Text = category.Name,
                Value = category.Id.ToString()
            });
        }
        public void SetCategories(List<Brands> cats)
        {
            _brands = cats;
        }
    }
}