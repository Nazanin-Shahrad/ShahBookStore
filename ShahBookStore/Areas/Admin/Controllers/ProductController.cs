using Microsoft.AspNetCore.Hosting;
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
            Product product = new Product();
            if (id == null)
            {
                return View(product);
            }
            product = _unitOfWork.Product.Get(id.GetValueOrDefault());
            if (product == null)
            {
                return NotFound();

            }
            return View(product);
        }




        [HttpGet]

            public IActionResult GetAll()
            {
                var allObj = _unitOfWork.Product.GetAll();
                return Json(new { data = allObj });
            }
          


        }
    }
