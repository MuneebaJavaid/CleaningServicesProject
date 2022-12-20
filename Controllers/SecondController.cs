using SaafCleaningProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace SaafCleaningProject.Controllers
{
    public class SecondController : Controller
    {

        private readonly ClientDbContext _CDb;
        public SecondController(ClientDbContext CDb)
        {
            _CDb = CDb;
        }

        public IActionResult CList()
        {
            var datalist = _CDb.CDataModels.ToList();
            return View(datalist);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(DataModel model)
        {
            _CDb.CDataModels.Add(model);
            _CDb.SaveChanges();
            return View();
        }

    }
}
