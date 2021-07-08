using Business.Abstract;
using DataAccess.Abstract;
using Microsoft.AspNetCore.Mvc;
using MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWebUI.Controllers
{
    public class CategoryController : Controller
    {
        private ICategoryDal _categoryService;
        public CategoryController(ICategoryDal categoryService)
        {
            _categoryService = categoryService;
        }
      
    }
}
