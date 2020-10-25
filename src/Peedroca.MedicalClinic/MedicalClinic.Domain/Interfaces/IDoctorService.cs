using MedicalClinic.Domain.Models;
using System;
using System.Collections.Generic;

namespace MedicalClinic.Domain.Interfaces
{
    /// <summary>
    /// Interface de Serviço Médico
    /// </summary>
    public interface IDoctorService : IDisposable
    {
        DoctorModel Create(CreateDoctorModel model);

        DoctorModel Update(UpdateDoctorModel model);

        IEnumerable<DoctorModel> GetDoctors();

        DoctorModel GetDoctorById(long id);
    }
}
