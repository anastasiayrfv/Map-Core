using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Map.Models;

namespace Map.Controllers
{
    public class HomeController : Controller
    {
        private IMapRepository repository;
        public HomeController(IMapRepository repo)
        {
            repository = repo;
        }

        public IActionResult Index()
        {
            //return Redirect("~/Admin/Index");
           return View("UserAuthorized");
        }

        [HttpPost]
        public JsonResult GetData2([FromBody] Filter parameters)
        {
            string type = parameters.Type;
            string query = parameters.SearchQuery;

            var places = repository.Places.Where(p => 
            ((string.IsNullOrEmpty(type) || type == "Все") || p.Type.Equals(type)));

            if (!string.IsNullOrEmpty(query))
            {
                string[] split = query.Split(new Char[] { ' ', ',', '.', ':', '\t' });
                List<string> list = new List<string>(split);

                places = repository.Places.Where(p =>  list.Contains(p.Name));
               // places = repository.Places.Where(p => p.Name.Contains());
            
            }

            return Json(places);
        }

        [HttpGet]
        public JsonResult GetData(string name)
        {
            return Json(repository.Places);
        }
    }
}
