using Microsoft.AspNetCore.Mvc;
using WebUI.Models.Entities;
using WebUI.Models.DataAccess;
using WebUI.Models.DataAccess.EFRepository.DalLayer.Concrete;
using WebUI.Models.DataAccess.EFRepository.DalLayer;
using WebUI.Models.DataAccess.EFRepository.DalLayer.OracleDb;

namespace WebUI.Controllers
{
    public class DepartmentsController : Controller
    {
        private readonly IDepartmentOracleDal _departmentDal;

        public DepartmentsController(IDepartmentOracleDal departmentDal)
        {
            _departmentDal = departmentDal;
        }

        public IActionResult Index()
        {
            var list = _departmentDal.GetList();
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
            _departmentDal.Add(department);


            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View(department);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var department = _departmentDal.Get(id);
            return View(department);
        }

        [HttpPost]
        public IActionResult Update(Department department)
        {

            if (ModelState.IsValid)
            {
                _departmentDal.Update(department);

                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var department = _departmentDal.Get(id);
            return View(department);
        }

        [HttpPost]
        public IActionResult Delete(Department department)
        {
            if (ModelState.IsValid)
            {
                _departmentDal.Delete(department);

                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
