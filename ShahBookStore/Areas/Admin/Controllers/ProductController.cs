using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using ShahsBooks.DataAccess.Repository.IRepository;
using ShahsBooks.Models;
using ShahsBooks.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShahBookStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
   
            private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _hostEnvironment;

            public ProductController(IUnitOfWork unitOfWork , IWebHostEnvironment hostEnvironment)
            {
                _unitOfWork = unitOfWork;
            _hostEnvironment = hostEnvironment;

            }

            public IActionResult Index()
            {
                return View();
            }

        public IActionResult Upsert(int? id)
        {
            ProductVM productVM = new ProductVM()
            {
                Product = new Product(),
                CategoryList = _unitOfWork.Category.GetAll().Select(i => new SelectListItem
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                }),
                CoverTypeList = _unitOfWork.CoverType.GetAll().Select(i => new SelectListItem
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                }),

        };
            if(id==null)
            {
                return View(productVM);
            }

            productVM.Product = _unitOfWork.Product.Get(id.GetValueOrDefault());
            if(productVM.Product == null)
            {
                return NotFound();
            }
            return View(productVM);
        }


        #region API CALLS

        [HttpGet]

            public IActionResult GetAll()
            {
                var allObj = _unitOfWork.Product.GetAll(includeProperties:"Category, CoverType");
                return Json(new { data = allObj });
            }
        [HttpDelete]

        public IActionResult Delete(int id)
        {
            var objFormDb = _unitOfWork.Product.Get(id);
            if(objFormDb == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

            _unitOfWork.Product.Remove(objFormDb);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete Successful" });
        }
        #endregion



    }
}
