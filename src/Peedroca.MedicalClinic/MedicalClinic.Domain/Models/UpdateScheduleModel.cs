using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalClinic.Domain.Models
{
    /// <summary>
    /// Modelo de atualização de agendamento
    /// </summary>
    public class UpdateScheduleModel
    {
        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="id">Identificação</param>
        /// <param name="date">Data</param>
        /// <param name="customer">Paciênte</param>
        /// <param name="doctor">Médico</param>
        public UpdateScheduleModel(long id, DateTime date, CustomerModel customer, DoctorModel doctor)
        {
            Id = id;
            Date = date;
            Customer = customer;
            Doctor = doctor;
        }

        /// <summary>
        /// Identificação
        /// </summary>
        public long Id { get; }

        /// <summary>
        /// Data
        /// </summary>
        public DateTime Date { get; }

        /// <summary>
        /// Paciênte
        /// </summary>
        public CustomerModel Customer { get; }

        /// <summary>
        /// Médico
        /// </summary>
        public DoctorModel Doctor { get; }
    }
}
