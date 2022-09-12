﻿using Core6App.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace Core6App.Web.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _productService.GetProductsWithCategory());
        }
    }
}