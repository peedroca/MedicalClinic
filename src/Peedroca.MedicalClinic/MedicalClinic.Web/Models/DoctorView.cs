using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalClinic.Web.Models
{
    /// <summary>
    /// Visualização do Médico
    /// </summary>
    public class DoctorView
    {
        /// <summary>
        /// Identificação
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Nome
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Especialidade
        /// </summary>
        public string Specialty { get; set; }

        /// <summary>
        /// Telefone
        /// </summary>
        public string Phone { get; set; }
    }
}
