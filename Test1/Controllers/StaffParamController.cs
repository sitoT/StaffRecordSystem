using Microsoft.AspNetCore.Mvc;
using Test1.EFDataConnection;
using Test1.Models;

namespace Test1.Controllers
{
    public class StaffParamController : Controller
    {
        private readonly ApplicationDbContext _db;

        public StaffParamController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<StaffParam> StaffDetails = _db.StaffParams;

            return View(StaffDetails);
        }


        //GET
        
        public IActionResult Create()
        {

            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Create(StaffParam obj)
        {
            if(ModelState.IsValid)
            {
                _db.StaffParams.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        
        //GET
        
        public IActionResult Edit(int? id)
        {
            var StaffId = _db.StaffParams.Find(id);

            return View(StaffId);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Edit(StaffParam obj)
        {
            if(ModelState.IsValid)
            {
                _db.StaffParams.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
         
        //GET
        
        public IActionResult Delete(int? id)
        {
            var StaffId = _db.StaffParams.Find(id);

            return View(StaffId);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult DeleteStaffRecord(int? obj)

        {
            var StaffRecord = _db.StaffParams.Find(obj);
            if(StaffRecord==null)
            {
                return NotFound();
            }

            _db.StaffParams.Remove(StaffRecord);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
