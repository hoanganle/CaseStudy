using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CaseStudy.Models;
namespace CaseStudy.Controllers
{
    public class DataController : Controller
    {
        AppDbContext _ctx;
        public DataController(AppDbContext context)
        {
            _ctx = context;
        }
        public async Task<IActionResult> Index()
        {
            UtilityModel util = new UtilityModel(_ctx);
            string msg = "";
            var json = await getMenuItemJsonFromWebAsync();
            try
            {
                msg = (util.loadTables(json)) ? "tables loaded" : "problem loading tables";
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            ViewBag.LoadedMsg = msg;
            return View();
        }

        private async Task<String> getMenuItemJsonFromWebAsync()
        {
            string url = "https://api.myjson.com/bins/14rlyv";
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(url);
            var result = await response.Content.ReadAsStringAsync();
            return result;
        }
    }
}