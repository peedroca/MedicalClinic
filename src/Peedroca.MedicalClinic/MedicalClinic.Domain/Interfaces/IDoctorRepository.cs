using MedicalClinic.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalClinic.Domain.Interfaces
{
    /// <summary>
    /// Interface do repositório Médico
    /// </summary>
    public interface IDoctorRepository : IDisposable
    {
        /// <summary>
        /// Salvar médico
        /// </summary>
        /// <param name="entity">Entidade médico</param>
        void SaveDoctor(DoctorEntity entity);

        /// <summary>
        /// Obter médicos
        /// </summary>
        /// <returns>Lista de objetos do tipo <see cref="DoctorEntity"/></returns>
        IEnumerable<DoctorEntity> GetDoctors();
    }
}
