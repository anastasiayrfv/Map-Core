using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Map.Models;
using Microsoft.AspNetCore.Mvc;

namespace Map.Controllers
{
    public class AdminController : Controller
    {

        private IMapRepository repository;
        public AdminController(IMapRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index() => View(repository.Places);

        public PartialViewResult EditPlace(int Id) =>
        PartialView("_EditPlace", repository.Places
        .FirstOrDefault(p => p.Id == Id));

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditPlace(Place place)
        {
           // if (ModelState.IsValid)
           // {
                repository.SavePlace(place);
                TempData["message"] = $"{place.Name} has been saved";
                return RedirectToAction("Index");
            //}
            //else
            //{
            //    return PartialView("_EditPlace", place);
            //}
        }
        
        [HttpPost]
        public IActionResult DeletePlace(int Id)
        {
            Place deleted = repository.DeletePlace(Id);

            if (deleted != null)
                TempData["message"] = $"{deleted.Name} was deleted";
            
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult DeleteUser(int Id)
        {
            User deleted = repository.DeleteUser(Id);

            if (deleted != null)
                TempData["message"] = $"{deleted.Name} was deleted";

            return RedirectToAction("Index");
        }
        public ViewResult Create() => View("_EditPlace", new Place());
    }
}