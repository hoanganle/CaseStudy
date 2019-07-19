using Microsoft.AspNetCore.Mvc;
using CaseStudy.Models;
using System.Collections.Generic;
using CaseStudy.Utils;
using System;
namespace CaseStudy.Controllers
{
    public class BrandController : Controller
    {
        AppDbContext _db;
        public BrandController(AppDbContext context)
        {
            _db = context;
        }
        public IActionResult Index(BrandViewModel vm)
        {
            // only build the catalogue once
            if (HttpContext.Session.Get<List<Brands>>("brands") == null)
            {
                // no session information so let's go to the database
                try
                {
                    BrandModel catModel = new BrandModel(_db);
                    // now load the categories
                    List<Brands> brands= catModel.GetAll();
                    HttpContext.Session.Set<List<Brands>>("brands", brands);
                    vm.SetCategories(brands);
                }
                catch (Exception ex)
                {
                    ViewBag.Message = "Brand Problem - " + ex.Message;
                }
            }
            else
            {
                // no need to go back to the database as information is already in the session
                vm.SetCategories(HttpContext.Session.Get<List<Brands>>("brands"));
            }
            return View(vm);
        }

        public IActionResult SelectCategory(BrandViewModel vm)
        {
            BrandModel catModel = new BrandModel(_db);
            ProductModel menuModel = new ProductModel(_db);
            List<Products> items = menuModel.GetAllByCategory(vm.Id);
            List<ProductViewModel> vms = new List<ProductViewModel>();
            if (items.Count > 0)
            {
                foreach (Products item in items)
                {
                    ProductViewModel mvm = new ProductViewModel();
                    mvm.BrandId = item.BrandsId;
                    mvm.Qty = 0;
                    mvm.BrandName = catModel.GetName(item.BrandsId);
                    //mvm.BrandName = item.Brand.Name;
                    mvm.Description = item.Description;
                    mvm.Id = item.Id;
                    mvm.ProductName = item.ProductName;
                    mvm.GraphicName = item.GraphicName;
                    mvm.CostPrice = item.CostPrice;
                    mvm.MSRP = item.MSRP;
                    mvm.QtyOnHand = item.QtyOnHand;
                    mvm.QtyOnBackOrder = item.QtyOnBackOrder;
                    
                    vms.Add(mvm);
                }
                ProductViewModel[] myMenu = vms.ToArray();
                HttpContext.Session.Set<ProductViewModel[]>("menu", myMenu);
            }
            vm.SetCategories(HttpContext.Session.Get<List<Brands>>("brands"));
            return View("Index", vm); // need the original Index View here
        }

        public ActionResult SelectItem(BrandViewModel vm)
        {
            Dictionary<int, object> tray;
            if (HttpContext.Session.Get<Dictionary<int, Object>>("tray") == null)
            {
                tray = new Dictionary<int, object>();
            }
            else
            {
                tray = HttpContext.Session.Get<Dictionary<int, object>>("tray");
            }
            ProductViewModel[] menu = HttpContext.Session.Get<ProductViewModel[]>("menu");
            String retMsg = "";
            foreach (ProductViewModel item in menu)
            {
                if (item.BrandId == vm.Id)
                {
                    if (vm.Qty > 0) // update only selected item
                    {
                        item.Qty = vm.Qty;
                        retMsg = vm.Qty + " - item(s) Added!";
                        tray[item.Id] = item;
                    }
                    else
                    {
                        item.Qty = 0;
                        tray.Remove(item.Id);
                        retMsg = "item(s) Removed!";
                    }
                    vm.BrandId = item.BrandId;
                    break;
                }
            }
            ViewBag.AddMessage = retMsg;
            HttpContext.Session.Set<Dictionary<int, Object>>("tray", tray);
            vm.SetCategories(HttpContext.Session.Get<List<Brands>>("brands"));
            return View("Index", vm);
        }
    }

}


