namespace MedicalClinic.Domain.Entities
{
    /// <summary>
    /// Entidade Paciênte
    /// </summary>
    public class PatientEntity
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
        /// Telefone
        /// </summary>
        public string Phone { get; set; }
    }
}
