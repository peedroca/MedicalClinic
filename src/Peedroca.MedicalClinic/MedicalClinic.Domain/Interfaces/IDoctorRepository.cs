using MedicalClinic.Domain.Entities;
using System;
using System.Collections.Generic;

namespace MedicalClinic.Domain.Interfaces
{
    /// <summary>
    /// Interface do repositório Médico
    /// </summary>
    public interface IDoctorRepository
    {
        void SaveDoctor(DoctorEntity entity);

        IEnumerable<DoctorEntity> GetDoctors();

        DoctorEntity GetDoctorById(long id);
    }
}
