using Microsoft.AspNetCore.Mvc;
using ShahsBooks.DataAccess.Repository.IRepository;
using ShahsBooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShahBookStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CoverTypeController : Controller
    {

        private readonly IUnitOfWork _unitOfWork;

        public CoverTypeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upsert(int? id)
        {
            CoverType coverType = new CoverType();
            if (id == null)
            {
                return View(coverType);
            }
            coverType = _unitOfWork.CoverType.Get(id.GetValueOrDefault());
            if (coverType == null)
            {
                return NotFound();

            }
            return View(coverType);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Upsert(CoverType CoverType)
        {
            if (ModelState.IsValid)
            {
                if (CoverType.Id == 0)
                {
                    _unitOfWork.CoverType.Add(CoverType);

                }
                else
                {
                    _unitOfWork.CoverType.Update(CoverType);
                }
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(CoverType);
        }



        #region API CALLS
        [HttpGet]

        public IActionResult GetAll()
        {
            var allObj =_unitOfWork.CoverType.GetAll();
            return Json(new { data = allObj });
        }
    }
    #endregion
}
