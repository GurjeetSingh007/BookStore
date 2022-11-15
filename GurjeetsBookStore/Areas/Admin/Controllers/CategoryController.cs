using GurjeetsBooks.DataAccess.Repository.IRepository;
using GurjeetsBooks.Models;
using Microsoft.AspNetCore.Mvc;

namespace GurjeetsBookStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Category category)
        {
                if (ModelState.IsValid)
                {
                    if(category.Id == 0)
                    {
                        _unitOfWork.Category.Add(category);
                    }
                    else
                    {
                        _unitOfWork.Category.Update(category);
                    }
                    _unitOfWork.save();
                return RedirectToAction(nameof(Index));
                }
                return View(category);

        }

        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            var allObj = _unitOfWork.Category.GetAll();
            return Json(new {data = allObj});
        }
        #endregion 
    }
}
