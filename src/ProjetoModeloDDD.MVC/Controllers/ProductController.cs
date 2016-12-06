using AutoMapper;
using ProjetoModeloDDD.Application.Contracts;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.MVC.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ProjetoModeloDDD.MVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductAppService _productAppService;
        private readonly ICustomerAppService _customerAppService;

        public ProductController(IProductAppService productAppService, ICustomerAppService customerAppService)
        {
            _productAppService = productAppService;
            _customerAppService = customerAppService;
        }

        // GET: Product
        public ActionResult Index()
        {
            var viewModel = Mapper.Map<IEnumerable<Product>, IEnumerable<ProductViewModel>>(_productAppService.GetAll());
            return View(viewModel);
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            var product = _productAppService.GetById(id);
            var productViewModel = Mapper.Map<Product, ProductViewModel>(product);

            return View(productViewModel);
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            ViewBag.Customers = new SelectList(_customerAppService.GetAll(), "Id", "Name");
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductViewModel productViewModel)
        {
            if (ModelState.IsValid)
            {
                var product = Mapper.Map<ProductViewModel, Product>(productViewModel);
                _productAppService.Add(product);

                return RedirectToAction(nameof(Index));
            }

            ViewBag.Customers = new SelectList(_customerAppService.GetAll(), "Id", "Name");

            return View(productViewModel);
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            var product = _productAppService.GetById(id);
            var productViewModel = Mapper.Map<Product, ProductViewModel>(product);

            ViewBag.Customers = new SelectList(_customerAppService.GetAll(), "Id", "Name");

            return View(productViewModel);
        }

        // POST: Product/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProductViewModel productViewModel)
        {
            if (ModelState.IsValid)
            {
                var product = Mapper.Map<ProductViewModel, Product>(productViewModel);
                _productAppService.Update(product);

                return RedirectToAction(nameof(Index));
            }

            ViewBag.Customers = new SelectList(_customerAppService.GetAll(), "Id", "Name");

            return View(productViewModel);
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            var product = _productAppService.GetById(id);
            var productViewModel = Mapper.Map<Product, ProductViewModel>(product);

            return View(productViewModel);
        }

        // POST: Product/Delete/5
        [HttpPost, ActionName(nameof(Delete))]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var product = _productAppService.GetById(id);
            _productAppService.Remove(product);

            return RedirectToAction(nameof(Index));
        }
    }
}