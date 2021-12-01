using Microsoft.AspNetCore.Mvc;
using ShahsBooks.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShahBookStore.Areas.Admin.Controllers
{
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

        #region API CALLS
        [HttpGet]

        public IActionResult GetAll()
        {
            var allObj =_unitOfWork.CoverType.GetAll();
            return Json(new { data = allObj });
        }
    }
}
