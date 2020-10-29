using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MedicalClinic.Domain.Interfaces;
using MedicalClinic.Domain.Models;
using MedicalClinic.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace MedicalClinic.Web.Controllers
{
    public class CustomerController : Controller
    {
        private ICustomerService _customerService;
        private IMapper _mapper;

        public CustomerController(ICustomerService customerService, IMapper mapper)
        {
            _customerService = customerService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var customers = _customerService.GetCustomers();

            if (customers != null && customers.Count() > 0)
            {
                var customersView = _mapper.Map<IEnumerable<CustomerView>>(customers);
                ViewData["Customers"] = customersView;
            }
            else
                ViewData["Customers"] = new List<CustomerView>();

            return View();
        }

        public IActionResult Search(string name)
        {
            var customers = _customerService.GetCustomers()?.Where(w => w?.Name?.Contains(name) ?? false);

            if (customers != null && customers.Count() > 0)
            {
                var customersView = _mapper.Map<IEnumerable<CustomerView>>(customers);
                ViewData["Customers"] = customersView;
            }
            else
                ViewData["Customers"] = new List<CustomerView>();

            return View("Index");
        }

        [HttpGet("Customer/Edit/{id}")]
        public IActionResult Edit([FromRoute] long id)
        {
            var customer = _mapper.Map<CustomerView>(_customerService.GetCustomerById(id));
            ViewData["Customer"] = customer ?? new CustomerView();
            ViewData["CustomerId"] = id;

            return View();
        }

        public IActionResult New()
        {
            ViewData["Customer"] = new CustomerView();
            return View();
        }

        public IActionResult Create(CustomerView customer)
        {
            CreateCustomerModel create = new CreateCustomerModel(customer.Name
                , customer.Phone);

            if (create.Invalid)
            {
                ViewData["NameError"] = create.Notifications
                    .Where(w => w.Property == "Name")?
                    .FirstOrDefault()?
                    .Message;
                ViewData["PhoneError"] = create.Notifications
                    .Where(w => w.Property == "Phone")?
                    .FirstOrDefault()?
                    .Message;

                ViewData["Customer"] = customer ?? new CustomerView();
                return View("New");
            }

            ViewData["CustomerView"] = _mapper.Map<CustomerView>(_customerService.Create(create));
            return View();
        }

        public IActionResult Alter(CustomerView customer)
        {
            UpdateCustomerModel update = new UpdateCustomerModel(customer.Id
                , customer.Name
                , customer.Phone);

            if (update.Invalid)
            {
                ViewData["IdError"] = update.Notifications
                    .Where(w => w.Property == "Id")?
                    .FirstOrDefault()?
                    .Message;
                ViewData["NameError"] = update.Notifications
                    .Where(w => w.Property == "Name")?
                    .FirstOrDefault()?
                    .Message;
                ViewData["PhoneError"] = update.Notifications
                    .Where(w => w.Property == "Phone")?
                    .FirstOrDefault()?
                    .Message;

                ViewData["Customer"] = customer ?? new CustomerView();
                return View("Edit");
            }

            ViewData["CustomerView"] = _mapper.Map<CustomerView>(_customerService.Update(update));
            return View();
        }
    }
}
