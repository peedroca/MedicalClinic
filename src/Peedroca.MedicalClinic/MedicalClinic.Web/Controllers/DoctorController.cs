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
    public class DoctorController : Controller
    {
        private IDoctorService _doctorService;
        private IMapper _mapper;

        public DoctorController(IDoctorService doctorService, IMapper mapper)
        {
            _doctorService = doctorService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var doctors = _doctorService.GetDoctors();

            if (doctors != null && doctors.Count() > 0)
            {
                var doctorsView = _mapper.Map<IEnumerable<DoctorView>>(doctors);
                ViewData["Doctors"] = doctorsView;
            }
            else
                ViewData["Doctors"] = new List<DoctorView>();

            return View();
        }

        public IActionResult Search(string name)
        {
            var doctors = _doctorService.GetDoctors()?.Where(w => w?.Name?.Contains(name) ?? false);

            if (doctors != null && doctors.Count() > 0)
            {
                var doctorsView = _mapper.Map<IEnumerable<DoctorView>>(doctors);
                ViewData["Doctors"] = doctorsView;
            }
            else
                ViewData["Doctors"] = new List<DoctorView>();

            return View("Index");
        }

        [HttpGet("Doctor/Edit/{id}")]
        public IActionResult Edit([FromRoute] long id)
        {
            var doctor = _mapper.Map<DoctorView>(_doctorService.GetDoctorById(id));
            ViewData["Doctor"] = doctor ?? new DoctorView();
            ViewData["DoctorId"] = id;

            return View();
        }

        public IActionResult New()
        {
            ViewData["Doctor"] = new DoctorView();
            return View();
        }

        public IActionResult Create(DoctorView doctor)
        {
            CreateDoctorModel create = new CreateDoctorModel(doctor.Name
                , doctor.Specialty
                , doctor.Phone);

            if (create.Invalid)
            {
                ViewData["NameError"] = create.Notifications
                    .Where(w => w.Property == "Name")?
                    .FirstOrDefault()?
                    .Message;
                ViewData["SpecialtyError"] = create.Notifications
                    .Where(w => w.Property == "Specialty")?
                    .FirstOrDefault()?
                    .Message;
                ViewData["PhoneError"] = create.Notifications
                    .Where(w => w.Property == "Phone")?
                    .FirstOrDefault()?
                    .Message;

                ViewData["Doctor"] = doctor ?? new DoctorView();
                return View("New");
            }

            ViewData["DoctorView"] = _mapper.Map<DoctorView>(_doctorService.Create(create));
            return View();
        }

        public IActionResult Alter(DoctorView doctor)
        {
            UpdateDoctorModel update = new UpdateDoctorModel(doctor.Id
                , doctor.Name
                , doctor.Specialty
                , doctor.Phone);

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
                ViewData["SpecialtyError"] = update.Notifications
                    .Where(w => w.Property == "Specialty")?
                    .FirstOrDefault()?
                    .Message;
                ViewData["PhoneError"] = update.Notifications
                    .Where(w => w.Property == "Phone")?
                    .FirstOrDefault()?
                    .Message;

                ViewData["Doctor"] = doctor ?? new DoctorView();
                return View("Edit");
            }

            ViewData["DoctorView"] = _mapper.Map<DoctorView>(_doctorService.Update(update));
            return View();
        }
    }
}
