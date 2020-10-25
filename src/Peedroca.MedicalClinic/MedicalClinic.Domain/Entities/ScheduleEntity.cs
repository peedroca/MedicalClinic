using System;

namespace MedicalClinic.Domain.Entities
{
    /// <summary>
    /// Entidade Agendamento
    /// </summary>
    public class ScheduleEntity
    {
        /// <summary>
        /// Identificação
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Data
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Paciênte
        /// </summary>
        public CustomerEntity Customer { get; set; }

        /// <summary>
        /// Médico
        /// </summary>
        public DoctorEntity Doctor { get; set; }
    }
}
