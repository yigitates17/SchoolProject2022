using Microsoft.AspNetCore.Mvc;
using WebUI.Models.Entities;
using WebUI.Models.DataAccess;

namespace WebUI.Controllers
{
    public class DepartmentsController : Controller
    {
        SchoolProjectDbContext dbContext = new SchoolProjectDbContext();
        public IActionResult Index()
        {
            var list = dbContext.Departments.ToList();
            return View(list);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Department department)
        {
            dbContext.Departments.Add(department);
            dbContext.SaveChanges();

            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View(department);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var department = dbContext.Departments.Find(id);
            return View(department);
        }

        [HttpPost]
        public IActionResult Update(Department department)
        {

            if (ModelState.IsValid)
            {
                dbContext.Departments.Update(department);
                dbContext.SaveChanges();

                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var department = dbContext.Departments.Find(id);
            return View(department);
        }

        [HttpPost]
        public IActionResult Delete(Department department)
        {
            if (ModelState.IsValid)
            {
                dbContext.Departments.Remove(department);
                dbContext.SaveChanges();

                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
