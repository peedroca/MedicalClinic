using MedicalClinic.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

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
        void Create(CreateDoctorModel model);

        /// <summary>
        /// Atualizar médico
        /// </summary>
        /// <param name="model">Modelo de atualização de médico</param>
        void Update(UpdateDoctorModel model);

        /// <summary>
        /// Listar médicos
        /// </summary>
        /// <returns>Lista de objetos do tipo <see cref="DoctorModel"/></returns>
        IEnumerable<DoctorModel> GetDoctors();
    }
}
