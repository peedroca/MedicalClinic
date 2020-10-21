namespace MedicalClinic.Domain.Entities
{
    /// <summary>
    /// Entidade Médico
    /// </summary>
    public class DoctorEntity
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
