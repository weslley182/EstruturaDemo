using EstruturaDemo.Application;
using EstruturaDemo.Domain.Entities;
using EstruturaDemo.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EstruturaDemo.UI.MVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductApplication _productApplication;
        private readonly IProductRepository _productRepository;

        public ProductController(ProductApplication productApplication, IProductRepository productRepository)
        {
            _productApplication = productApplication;
            _productRepository = productRepository;
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _productApplication.Register(product);
                return RedirectToAction("Index");
            }
            return View(product);
        }

        // GET: Product
        public ActionResult Index()
        {
            var products = _productRepository.Get();
            return View(products);
        }
    }
}