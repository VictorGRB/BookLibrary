﻿using BookLibrary.Models;
using BookLibrary.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookLibrary.Controllers
{
    public class CustomerController : Controller
    {
        private BorrowFormRepository borrowFormRepository = new BorrowFormRepository();
        private Repository.CustomerRepository customerRepository = new Repository.CustomerRepository();
        // GET: Customer
        public ActionResult Index( string searchBy, string search)
        {
            List<Models.CustomerModel> customers = customerRepository.GetAllCustomers();
            if (searchBy == "Name")
            {
                return View(customers.Where(x => x.Name.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0 || search == null).ToList());
            }
            else if (searchBy == "EmailAddress")
            {
                return View(customers.Where(x => x.EmailAddress.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0 || search == null).ToList());
            }
            else
            {
                return View("Index", customers);
            }
        }

        // GET: Customer/Details/5
        public ActionResult Details(Guid id)
        {
            Models.CustomerModel customerModel = customerRepository.GetCustomerByID(id);
            return View("CustomerDetails",customerModel);
        }
        [Authorize(Roles = "Admin")]
        // GET: Customer/Create
        public ActionResult Create()
        {
            return View("CreateCustomer");
        }
        [Authorize(Roles = "Admin")]
        // POST: Customer/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                Models.CustomerModel customerModel = new Models.CustomerModel();
                UpdateModel(customerModel);
                customerRepository.InsertCustomer(customerModel);
                return RedirectToAction("Index");
            }
            catch
            {
                return View("CreateCustomer");
            }
        }
        [Authorize(Roles = "Admin")]
        // GET: Customer/Edit/5
        public ActionResult Edit(Guid id)
        {
            Models.CustomerModel customerModel = customerRepository.GetCustomerByID(id);
            return View("EditCustomer",customerModel);
        }
        [Authorize(Roles = "Admin")]
        // POST: Customer/Edit/5
        [HttpPost]
        public ActionResult Edit(Guid id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                Models.CustomerModel customerModel = new Models.CustomerModel();
                UpdateModel(customerModel);
                customerRepository.UpdateCustomer(customerModel);
                return RedirectToAction("Index");
            }
            catch
            {
                return View("EditCustomer");
            }
        }
        [Authorize(Roles = "Admin")]
        // GET: Customer/Delete/5
        public ActionResult Delete(Guid id)
        {
            Models.CustomerModel customerModel = customerRepository.GetCustomerByID(id);
            return View("DeleteCustomer",customerModel);
        }
        [Authorize(Roles = "Admin")]
        // POST: Customer/Delete/5
        [HttpPost]
        public ActionResult Delete(Guid id, FormCollection collection)
        {
            try
            {

                List<BorrowFormModel> borrowForms = borrowFormRepository.GetAllBorrowFormsByCustomerId(id);
                foreach(BorrowFormModel borrowForm in borrowForms)
                {
                    borrowFormRepository.DeleteBorrowForm(borrowForm.IDBorrowForm);
                }
                // TODO: Add delete logic here
                customerRepository.DeleteCustomer(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View("DeleteCustomer");
            }
        }
    }
}
