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
    public class ScheduleController : Controller
    {
        private IDoctorService _doctorService;
        private ICustomerService _customerService;
        private IScheduleService _scheduleService;
        private IMapper _mapper;

        public ScheduleController(IScheduleService scheduleService
            , IDoctorService doctorService
            , ICustomerService customerService
            , IMapper mapper)
        {
            _doctorService = doctorService;
            _customerService = customerService;
            _scheduleService = scheduleService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var schedules = _scheduleService.GetSchedules()?.OrderBy(o => o.Id)?.ToList();

            if (schedules != null && schedules.Count() > 0)
            {
                var schedulesView = _mapper.Map<IEnumerable<ScheduleView>>(schedules);
                ViewData["Schedules"] = schedulesView;
            }
            else
                ViewData["Schedules"] = new List<ScheduleView>();

            return View();
        }

        public IActionResult Search(string nameDoctor, string nameCustomer)
        {
            var schedules = _scheduleService.GetSchedules();

            if (schedules != null && schedules.Count() > 0)
            {
                if (!string.IsNullOrEmpty(nameDoctor))
                    schedules = schedules.Where(w => w.Doctor?.Name?.ToLower()?.Contains(nameDoctor?.ToLower()) ?? false)?.ToList();

                if (!string.IsNullOrEmpty(nameCustomer))
                    schedules = schedules.Where(w => w.Customer?.Name?.ToLower()?.Contains(nameCustomer?.ToLower()) ?? false)?.ToList();

                var schedulesView = _mapper.Map<IEnumerable<ScheduleView>>(schedules);
                ViewData["Schedules"] = schedulesView;
            }
            else
                ViewData["Schedules"] = new List<ScheduleView>();

            return View("Index");
        }

        [HttpGet("Schedule/Edit/{id}")]
        public IActionResult Edit([FromRoute] long id)
        {
            var schedule = _mapper.Map<ScheduleView>(_scheduleService.GetScheduleById(id));
            ViewData["Schedule"] = schedule ?? new ScheduleView();
            ViewData["ScheduleId"] = id;

            var doctors = _doctorService.GetDoctors();

            if (doctors != null && doctors.Count() > 0)
            {
                var doctorsView = _mapper.Map<IEnumerable<DoctorView>>(doctors)?.ToList();
                doctorsView.RemoveAll(r => r.Id == schedule.IdDoctor);
                ViewData["Doctors"] = doctorsView;
            }
            else
                ViewData["Doctors"] = new List<DoctorView>();

            var customers = _customerService.GetCustomers();

            if (customers != null && customers.Count() > 0)
            {
                var customersView = _mapper.Map<IEnumerable<CustomerView>>(customers)?.ToList();
                customersView.RemoveAll(r => r.Id == schedule.IdCustomer);
                ViewData["Customers"] = customersView;
            }
            else
                ViewData["Customers"] = new List<CustomerView>();            

            return View();
        }

        public IActionResult New()
        {
            var doctors = _doctorService.GetDoctors();

            if (doctors != null && doctors.Count() > 0)
            {
                var doctorsView = _mapper.Map<IEnumerable<DoctorView>>(doctors);
                ViewData["Doctors"] = doctorsView;
            }
            else
                ViewData["Doctors"] = new List<DoctorView>();

            var customers = _customerService.GetCustomers();

            if (customers != null && customers.Count() > 0)
            {
                var customersView = _mapper.Map<IEnumerable<CustomerView>>(customers);
                ViewData["Customers"] = customersView;
            }
            else
                ViewData["Customers"] = new List<CustomerView>();

            ViewData["Schedule"] = new ScheduleView();
            return View();
        }

        public IActionResult Create(long CustomerId, long DoctorId, string Date)
        {
            CreateScheduleModel create = new CreateScheduleModel(Convert.ToDateTime(Date)
                , _customerService.GetCustomerById(CustomerId)
                , _doctorService.GetDoctorById(DoctorId));

            if (create.Invalid)
            {
                ViewData["CustomerError"] = create.Notifications
                    .Where(w => w.Property == "Customer")?
                    .FirstOrDefault()?
                    .Message;
                ViewData["DoctorError"] = create.Notifications
                    .Where(w => w.Property == "Doctor")?
                    .FirstOrDefault()?
                    .Message;

                return View("New");
            }

            ViewData["ScheduleView"] = _mapper.Map<ScheduleView>(_scheduleService.Create(create));
            return View();
        }

        [HttpGet("Schedule/Delete/{id}")]
        public IActionResult Delete([FromRoute] long id)
        {
            try
            {
                _scheduleService.Delete(id);
                return View();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IActionResult Alter(long CustomerId, long DoctorId, string Date, long id)
        {
            UpdateScheduleModel update = new UpdateScheduleModel(id
                , Convert.ToDateTime(Date)
                , _customerService.GetCustomerById(CustomerId)
                , _doctorService.GetDoctorById(DoctorId));

            if (update.Invalid)
            {
                ViewData["CustomerError"] = update.Notifications
                    .Where(w => w.Property == "Customer")?
                    .FirstOrDefault()?
                    .Message;
                ViewData["DoctorError"] = update.Notifications
                    .Where(w => w.Property == "Doctor")?
                    .FirstOrDefault()?
                    .Message;

                return View("New");
            }

            ViewData["ScheduleView"] = _mapper.Map<ScheduleView>(_scheduleService.Update(update));
            return View();
        }
    }
}
