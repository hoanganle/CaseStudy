using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CaseStudy.Models;
namespace CaseStudy.Models
{
    public class UtilityModel
    {
        private AppDbContext _db;
        public UtilityModel(AppDbContext context) // will be sent by controller
        {
            _db = context;
        }
        public bool loadTables(string stringJson)
        {
            bool brandsLoaded = false;
            bool productsLoaded = false;
            try
            {
                dynamic objectJson = Newtonsoft.Json.JsonConvert.DeserializeObject(stringJson);
                brandsLoaded = loadBrands(objectJson);
                productsLoaded = loadProducts(objectJson);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return brandsLoaded && productsLoaded;
        }        private bool loadBrands(dynamic objectJson)
        {
            bool loadedBrands = false;
            try
            {
                // clear out the old rows
                _db.Brands.RemoveRange(_db.Brands);
                _db.SaveChanges();
                List<String> allBrands = new List<String>();
                foreach (var node in objectJson)
                {
                    allBrands.Add(Convert.ToString(node["Brands"]));
                }
                // distinct will remove duplicates before we insert them into the db
                IEnumerable<String> brands = allBrands.Distinct<String>();
                foreach (string catname in brands)
                {
                    Brands cat = new Brands();
                    cat.Name = catname;
                    _db.Brands.Add(cat);
                    _db.SaveChanges();
                }
                loadedBrands = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error - " + ex.Message);
            }
            return loadedBrands;
        }        private bool loadProducts(dynamic objectJson)
        {
            bool loadedProducts = false;
            try
            {
                List<Brands> brands = _db.Brands.ToList();
                // clear out the old
                _db.Products.RemoveRange(_db.Products);
                _db.SaveChanges();
                foreach (var node in objectJson)
                {
                    Products item = new Products();
                    item.ProductName = Convert.ToString(node["ProductName"]);
                    item.GraphicName = Convert.ToString(node["GraphicName"]);
                    item.CostPrice = Convert.ToDecimal(node["CostPrice"].Value);
                    item.MSRP = Convert.ToDecimal(node["MSRP"].Value);
                    item.QtyOnHand = Convert.ToInt32(node["QtyOnHand"].Value);
                    item.QtyOnBackOrder = Convert.ToInt32(node["QtyOnBackOrder"].Value);
                    item.Description = Convert.ToString(node["Description"]);
                    string cat = Convert.ToString(node["Brands"].Value);
                    // add the FK here
                    foreach (Brands category in brands)
                    {
                        if (category.Name == cat)
                            item.Brand = category;
                    }
                    _db.Products.Add(item);
                    _db.SaveChanges();
                }
                loadedProducts = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error - " + ex.Message);
            }
            return loadedProducts;
        }
    }
}
