using eManager.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eManager.Web.Controllers
{
    public class DepartmentsController : Controller
    {
        IDepartmentRepository _repository;

        public DepartmentsController(IDepartmentRepository repository)
        {
            _repository = repository;
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Your app description page xxx.";
            var departments = _repository.GetAll();
            return View(departments);
        }

    }
}
