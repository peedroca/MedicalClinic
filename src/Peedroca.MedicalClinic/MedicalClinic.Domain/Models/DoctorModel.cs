namespace MedicalClinic.Domain.Models
{
    /// <summary>
    /// Modelo de Médico
    /// </summary>
    public class DoctorModel
    {
        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="id">Identificação</param>
        /// <param name="name">Nome</param>
        /// <param name="specialty">Especialidade</param>
        /// <param name="phone">Telefone</param>
        public DoctorModel(long id
            , string name
            , string specialty
            , string phone)
        {
            Id = id;
            Name = name;
            Specialty = specialty;
            Phone = phone;
        }

        /// <summary>
        /// Identificação
        /// </summary>
        public long Id { get; }

        /// <summary>
        /// Nome
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Especialidade
        /// </summary>
        public string Specialty { get; }

        /// <summary>
        /// Telefone
        /// </summary>
        public string Phone { get; }
    }
}
