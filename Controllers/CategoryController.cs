using Microsoft.AspNetCore.Mvc;
using RockyProject.Data;
using RockyProject.Data.Repository.IRepository;
using RockyProject.Models;

namespace RockyProject.Controllers
{
    public class CategoryController : Controller
    {
        //creating depemdency injection

        //private readonly ApplicationDbContext _db;
        private readonly ICategoryRepository _cateRepo;
        //constructor
         
        public CategoryController(ICategoryRepository cateRepo)
        {
            _cateRepo = cateRepo;
        }

         IActionResult Index()
        {

            IEnumerable<Category> objList = _cateRepo.GetAll();
            return View(objList);
        }

        //Get for create
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        // With forms append tokens  validate token as security
        [ValidateAntiForgeryToken]
        //Post for create
        public IActionResult Create(Category obj)
        {
            if (ModelState.IsValid)
            {
                _cateRepo.Add(obj);
                _cateRepo.Save();
                TempData[WC.Success] = "Category Created Successfully";

                return RedirectToAction("Index");

            }
            else
            {
                TempData[WC.Error] = "Category Not Created Successfully";

                return View(obj);
            }
        }

        /// get - edit
        public IActionResult Edit(int? id)
        {

            if (id == null || id == 0)
            {
                return NotFound();
            }
            else
            {
                var obj = _cateRepo.Find(id.GetValueOrDefault());
                if (obj == null)
                {
                    return NotFound();
                }
                else
                {
                    return View(obj);
                }
            }
        }
        [HttpPost]
        // With forms append tokens  validate token as security
        [ValidateAntiForgeryToken]
        //Post for edit
        public IActionResult Edit(Category obj)
        {
            if (ModelState.IsValid)
            {
                _cateRepo.Update(obj);
                _cateRepo.Save();
                TempData[WC.Success] = "Category Edited Successfully";

                return RedirectToAction("Index");

            }
            else
            {
                TempData[WC.Error] = "Category Edited Failed";

                return View(obj);
            }
        }

        /// get - delete
        public IActionResult Delete(int? id)
        {

            if (id == null || id == 0)
            {
                return NotFound();
            }
            else
            {
                var obj = _cateRepo.Find(id.GetValueOrDefault());
                if (obj == null)
                {
                    return NotFound();
                }
                else
                {
                    return View(obj);
                }
            }
        }
        [HttpPost]
        // With forms append tokens  validate token as security
        [ValidateAntiForgeryToken]
        //Post for Delete
        public IActionResult DeletePost(int? id)
        {
            var obj = _cateRepo.Find(id.GetValueOrDefault());
                if (obj == null)
            {
                return NotFound();
            }
            _cateRepo.Remove(obj);
            _cateRepo.Save();
            TempData[WC.Success] = "Category Deleted Successfully";

            return RedirectToAction("Index");

           
        }


    }
}
