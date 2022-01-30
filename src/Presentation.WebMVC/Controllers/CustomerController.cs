using CRUD.EFCore.Domain.Core;
using CRUD.EFCore.Domain.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace CRUD.EFCore.Presentation.WebMVC.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository customerRepository;

        public CustomerController(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        // GET: CustomerController
        public ActionResult Index()
        {
            return View(customerRepository.GetAll());
        }

        // GET: CustomerController/Details/5
        public ActionResult Details(Guid id)
        {
            var customer = customerRepository.GetById(id);
            return View(customer);
        }

        // GET: CustomerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Customer customer)
        {
            try
            {
                customer.Contacts = new List<Contact>() { new Contact { ContactType = "Email", Content = $"{customer.FirstName}@gmail.com", Customer = customer } };
                this.customerRepository.Add(customer);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit(Guid id)
        {
            var customer = customerRepository.GetById(id);
            return View(customer);
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Guid id, Customer customer)
        {
            try
            {
                customer.CustomerId = id;
                this.customerRepository.Update(customer);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Delete/5
        public ActionResult Delete(Guid id)
        {
            var customer = customerRepository.GetById(id);
            return View(customer);
        }

        // POST: CustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Guid id, Customer customer)
        {
            try
            {
                customer.CustomerId = id;
                this.customerRepository.Remove(customer);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
