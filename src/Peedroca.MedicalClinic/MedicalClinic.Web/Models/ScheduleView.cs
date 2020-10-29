using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalClinic.Web.Models
{
    /// <summary>
    /// Visualização do agendamento
    /// </summary>
    public class ScheduleView
    {
        /// <summary>
        /// Identificação
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Identificação do Paciênte
        /// </summary>
        public long IdCustomer { get; set; }

        /// <summary>
        /// Identificação do médico
        /// </summary>
        public long IdDoctor { get; set; }

        /// <summary>
        /// Data
        /// </summary>
        public DateTime Date { get; set; }
              
        /// <summary>
        /// Nome do Paciênte
        /// </summary>
        public string NameCustomer { get; set; }

        /// <summary>
        /// Telefone do Paciênte
        /// </summary>
        public string PhoneCustomer { get; set; }

        /// <summary>
        /// Nome do médico
        /// </summary>
        public string NameDoctor { get; set; }

        /// <summary>
        /// Especialidade do médico
        /// </summary>
        public string SpecialtyDoctor { get; set; }

        /// <summary>
        /// Telefone do médico
        /// </summary>
        public string PhoneDoctor { get; set; }
    }
}
