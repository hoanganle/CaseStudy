using Microsoft.AspNetCore.Mvc;
using CaseStudy.Models;
namespace CaseStudy.Controllers
{
    public class ProductController : Controller
    {
        AppDbContext _db;
        public ProductController(AppDbContext context)
        {
            _db = context;
        }
        public IActionResult Index(BrandViewModel category)
        {
            ProductModel model = new ProductModel(_db);
            ProductViewModel viewModel = new ProductViewModel();
            viewModel.Items = model.GetAllByCategory(category.Id);
            viewModel.BrandName = model.GetCategory(category.Id).Name;
            return View(viewModel);
        }
    }
}