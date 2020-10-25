using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalClinic.Domain.Models
{
    /// <summary>
    /// Modelo de criação de agendamento
    /// </summary>
    public class CreateScheduleModel : Notifiable
    {
        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="date">Data</param>
        /// <param name="customer">Paciênte</param>
        /// <param name="doctor">Médico</param>
        public CreateScheduleModel(DateTime date, CustomerModel customer, DoctorModel doctor)
        {
            Date = date;
            Customer = customer;
            Doctor = doctor;
        }

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
