﻿using System;
using System.Collections.Generic;
using System.Text;

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
        public PatientEntity Patient { get; set; }

        /// <summary>
        /// Médico
        /// </summary>
        public DoctorEntity Doctor { get; set; }
    }
}
