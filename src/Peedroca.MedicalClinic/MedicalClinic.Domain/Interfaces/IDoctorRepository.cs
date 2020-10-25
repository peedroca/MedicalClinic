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

        /// <summary>
        /// Obter médico
        /// </summary>
        /// <param name="id">Identificação</param>
        /// <returns></returns>
        DoctorEntity GetDoctorById(long id);
    }
}
