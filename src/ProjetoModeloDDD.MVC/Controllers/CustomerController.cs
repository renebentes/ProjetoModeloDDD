using AutoMapper;
using ProjetoModeloDDD.Application.Contracts;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.MVC.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ProjetoModeloDDD.MVC.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerAppService _customerAppService;

        public CustomerController(ICustomerAppService customerAppService)
        {
            _customerAppService = customerAppService;
        }

        // GET: Customer
        public ActionResult Index()
        {
            var viewModel = Mapper.Map<IEnumerable<Customer>, IEnumerable<CustomerViewModel>>(_customerAppService.GetAll());
            return View(viewModel);
        }

        // GET: Customer/Specials
        public ActionResult Specials()
        {
            var viewModel = Mapper.Map<IEnumerable<Customer>, IEnumerable<CustomerViewModel>>(_customerAppService.GetSpecialsCustomers());
            return View(viewModel);
        }

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            var customer = _customerAppService.GetById(id);
            var customerViewModel = Mapper.Map<Customer, CustomerViewModel>(customer);

            return View(customerViewModel);
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CustomerViewModel customerViewModel)
        {
            if (ModelState.IsValid)
            {
                var customer = Mapper.Map<CustomerViewModel, Customer>(customerViewModel);
                _customerAppService.Add(customer);

                return RedirectToAction(nameof(Index));
            }

            return View(customerViewModel);
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            var customer = _customerAppService.GetById(id);
            var customerViewModel = Mapper.Map<Customer, CustomerViewModel>(customer);

            return View(customerViewModel);
        }

        // POST: Customer/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CustomerViewModel customerViewModel)
        {
            if (ModelState.IsValid)
            {
                var customer = Mapper.Map<CustomerViewModel, Customer>(customerViewModel);
                _customerAppService.Update(customer);

                return RedirectToAction(nameof(Index));
            }

            return View(customerViewModel);
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            var customer = _customerAppService.GetById(id);
            var customerViewModel = Mapper.Map<Customer, CustomerViewModel>(customer);

            return View(customerViewModel);
        }

        // POST: Customer/Delete/5
        [HttpPost, ActionName(nameof(Delete))]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var customer = _customerAppService.GetById(id);
            _customerAppService.Remove(customer);

            return RedirectToAction(nameof(Index));
        }
    }
}