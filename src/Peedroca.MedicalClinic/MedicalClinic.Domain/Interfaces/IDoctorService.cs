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
        /// <summary>
        /// Criar médico
        /// </summary>
        /// <param name="model">Modelo de criação de médico</param>
        DoctorModel Create(CreateDoctorModel model);

        /// <summary>
        /// Atualizar médico
        /// </summary>
        /// <param name="model">Modelo de atualização de médico</param>
        DoctorModel Update(UpdateDoctorModel model);

        /// <summary>
        /// Listar médicos
        /// </summary>
        /// <returns>Lista de objetos do tipo <see cref="DoctorModel"/></returns>
        IEnumerable<DoctorModel> GetDoctors();

        /// <summary>
        /// Obter médico
        /// </summary>
        /// <param name="id">identificação</param>
        /// <returns></returns>
        DoctorModel GetDoctorById(long id);
    }
}
