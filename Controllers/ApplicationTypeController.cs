using Microsoft.AspNetCore.Mvc;
using RockyProject.Data;
using RockyProject.Data.Repository.IRepository;
using RockyProject.Models;


namespace RockyProject.Controllers
{
    public class ApplicationTypeController : Controller
    {
        //creating depemdency injection

        private readonly IApplicationTypeRepository _appTypeRepo;

        //constructor

        public ApplicationTypeController(IApplicationTypeRepository appTypeRepo)
        {
            _appTypeRepo = appTypeRepo;
        }

        public IActionResult Index()
        {

            IEnumerable<ApplicationType> objList = _appTypeRepo.GetAll();
            return View(objList);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        // With forms append tokens  validate token as security 
        [ValidateAntiForgeryToken]
        //Post for create
        public IActionResult Create(ApplicationType obj)
        {
            if (ModelState.IsValid){
                _appTypeRepo.Add(obj);
                _appTypeRepo.Save();
                return RedirectToAction("Index");

            }
            else
            {
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
                var obj = _appTypeRepo.Find(id.GetValueOrDefault());
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
        public IActionResult Edit(ApplicationType obj)
        {
            if (ModelState.IsValid)
            {
                _appTypeRepo.Update(obj);
                _appTypeRepo.Save();
                return RedirectToAction("Index");

            }
            else
            {
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
                var obj = _appTypeRepo.Find(id.GetValueOrDefault());
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
            var obj = _appTypeRepo.Find(id.GetValueOrDefault());
            if (obj == null)
            {
                return NotFound();
            }
            _appTypeRepo.Remove(obj);
            _appTypeRepo.Save();
            return RedirectToAction("Index");


        }


    }

}
